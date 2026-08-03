using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsGestionAlumno
    {
        //atrubuto
        private string busqueda;

        private MySqlDataAdapter consulta;
        private DataTable tabla;

        // Es string (no int) porque acepta buscar tanto por matrícula como por nombre.
        public string Busqueda { get => busqueda; set => busqueda = value; }



        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    /* Se trae el registro completo incluyendo la cadena de dirección normalizada:
                    tbldireccion, tblcolonias, tblcodigo_postal, tblmunicipios
                    para que al editar no se necesite una segunda consulta a la base de datos.
                    id_carrera, id_direccion e id_colonia van al final y se ocultan en la grid,
                    solo sirven para preseleccionar combos al editar.*/
                    string sql = "SELECT a.matricula AS 'Matricula', " +
                                    "CONCAT(a.nombre,' ', a.apellido_paterno,' ', a.apellido_materno) AS 'Nombre completo', " +
                                    "a.nombre AS 'Nombre', " +
                                    "a.apellido_paterno AS 'Apellido Paterno', " +
                                    "a.apellido_materno AS 'Apellido Materno', " +
                                    "d.calle AS 'Calle', " +
                                    "col.nombre_colonia AS 'Colonia', " +
                                    "cp.codigo_postal AS 'Código Postal', " +
                                    "m.nombre_municipio AS 'Municipio', " +
                                    "c.nombre_carrera AS 'Carrera', " +
                                    "a.grado AS 'Grado', " +
                                    "a.grupo AS 'Grupo', " +
                                    "a.email AS 'Correo electrónico', " +
                                    "a.telefono AS 'Teléfono', " +
                                    "a.estado AS 'Estatus', " +
                                    "a.fecha_registro AS 'Fecha de Registro', " +
                                    "a.id_carrera AS 'id_carrera', " +
                                    "a.id_direccion AS 'id_direccion', " +
                                    "d.id_colonia AS 'id_colonia' " +
                                "FROM tblalumnos a " +
                                "LEFT JOIN tblcarreras c ON a.id_carrera = c.id_carrera " +
                                "LEFT JOIN tbldireccion d ON a.id_direccion = d.id_direccion " +
                                "LEFT JOIN tblcolonias col ON d.id_colonia = col.id_colonia " +
                                "LEFT JOIN tblcodigo_postal cp ON col.codigo_postal = cp.codigo_postal " +
                                "LEFT JOIN tblmunicipios m ON cp.id_municipio = m.id_municipio " +
                                "WHERE a.estado = 'Activo';";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT a.matricula AS 'Matricula', " +
                                    "CONCAT(a.nombre,' ', a.apellido_paterno,' ', a.apellido_materno) AS 'Nombre completo', " +
                                    "a.nombre AS 'Nombre', " +
                                    "a.apellido_paterno AS 'Apellido Paterno', " +
                                    "a.apellido_materno AS 'Apellido Materno', " +
                                    "d.calle AS 'Calle', " +
                                    "col.nombre_colonia AS 'Colonia', " +
                                    "cp.codigo_postal AS 'Código Postal', " +
                                    "m.nombre_municipio AS 'Municipio', " +
                                    "c.nombre_carrera AS 'Carrera', " +
                                    "a.grado AS 'Grado', " +
                                    "a.grupo AS 'Grupo', " +
                                    "a.email AS 'Correo electrónico', " +
                                    "a.telefono AS 'Teléfono', " +
                                    "a.estado AS 'Estatus', " +
                                    "a.fecha_registro AS 'Fecha de Registro', " +
                                    "a.id_carrera AS 'id_carrera', " +
                                    "a.id_direccion AS 'id_direccion', " +
                                    "d.id_colonia AS 'id_colonia' " +
                                "FROM tblalumnos a " +
                                "LEFT JOIN tblcarreras c ON a.id_carrera = c.id_carrera " +
                                "LEFT JOIN tbldireccion d ON a.id_direccion = d.id_direccion " +
                                "LEFT JOIN tblcolonias col ON d.id_colonia = col.id_colonia " +
                                "LEFT JOIN tblcodigo_postal cp ON col.codigo_postal = cp.codigo_postal " +
                                "LEFT JOIN tblmunicipios m ON cp.id_municipio = m.id_municipio " +
                                "WHERE (a.matricula LIKE @busqueda " +
                                   "OR a.nombre LIKE @busqueda) " +
                                   "AND a.estado = 'Activo'; ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }
            return tabla;
        }


        // Búsqueda exacta por matrícula (no LIKE) para Préstamos; solo alumnos 'Activo'.
        public DataTable BuscarPorMatricula(int matriculaBuscada)
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT a.nombre AS 'Nombre', " +
                                    "a.apellido_paterno AS 'Apellido Paterno', " +
                                    "a.apellido_materno AS 'Apellido Materno', " +
                                    "IFNULL(c.nombre_carrera, '') AS 'Carrera', " +
                                    "a.grado AS 'Grado', " +
                                    "a.grupo AS 'Grupo' " +
                                "FROM tblalumnos a " +
                                "LEFT JOIN tblcarreras c ON a.id_carrera = c.id_carrera " +
                                "WHERE a.matricula = @matricula AND a.estado = 'Activo';";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@matricula", matriculaBuscada);
                        using (var adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar al alumno: " + ex.Message);
            }
            return tabla;
        }
    }
}

