using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsGestionTrabajador
    {
        //atrubuto
        private int numComtrol;

        private MySqlDataAdapter consulta;
        private DataTable tabla;

        //propiedad
        public int NumComtrol { get => numComtrol; set => numComtrol = value; }

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
                    string sql = "SELECT t.numero_control AS 'Número de Control', " +
                                    "CONCAT(t.nombre,' ', t.apellido_paterno,' ', t.apellido_materno) AS 'Nombre completo', " +
                                    "t.nombre AS 'Nombre', " +
                                    "t.apellido_paterno AS 'Apellido Paterno', " +
                                    "t.apellido_materno AS 'Apellido Materno', " +
                                    "d.calle AS 'Calle', " +
                                    "col.nombre_colonia AS 'Colonia', " +
                                    "cp.codigo_postal AS 'Código Postal', " +
                                    "m.nombre_municipio AS 'Municipio', " +
                                    "IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS 'Carrera', " +
                                    "t.email AS 'Correo electrónico', " +
                                    "t.telefono AS 'Teléfono', " +
                                    "t.estado AS 'Estatus', " +
                                    "t.fecha_registro AS 'Fecha de Registro', " +
                                    "t.id_carrera AS 'id_carrera', " +
                                    "t.id_direccion AS 'id_direccion', " +
                                    "d.id_colonia AS 'id_colonia' " +
                                "FROM tbltrabajadores t " +
                                "LEFT JOIN tblcarreras c ON t.id_carrera = c.id_carrera " +
                                "LEFT JOIN tbldireccion d ON t.id_direccion = d.id_direccion " +
                                "LEFT JOIN tblcolonias col ON d.id_colonia = col.id_colonia " +
                                "LEFT JOIN tblcodigo_postal cp ON col.codigo_postal = cp.codigo_postal " +
                                "LEFT JOIN tblmunicipios m ON cp.id_municipio = m.id_municipio; ";

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
                    string sql = "SELECT t.numero_control AS 'Número de Control', " +
                                     "CONCAT(t.nombre,' ', t.apellido_paterno,' ', t.apellido_materno) AS 'Nombre completo', " +
                                    "t.nombre AS 'Nombre', " +
                                    "t.apellido_paterno AS 'Apellido Paterno', " +
                                    "t.apellido_materno AS 'Apellido Materno', " +
                                    "d.calle AS 'Calle', " +
                                    "col.nombre_colonia AS 'Colonia', " +
                                    "cp.codigo_postal AS 'Código Postal', " +
                                    "m.nombre_municipio AS 'Municipio', " +
                                    "IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS 'Carrera', " +
                                    "t.email AS 'Correo electrónico', " +
                                    "t.telefono AS 'Teléfono', " +
                                    "t.estado AS 'Estatus', " +
                                    "t.fecha_registro AS 'Fecha de Registro', " +
                                    "t.id_carrera AS 'id_carrera', " +
                                    "t.id_direccion AS 'id_direccion', " +
                                    "d.id_colonia AS 'id_colonia' " +
                                "FROM tbltrabajadores t " +
                                "LEFT JOIN tblcarreras c ON t.id_carrera = c.id_carrera " +
                                "LEFT JOIN tbldireccion d ON t.id_direccion = d.id_direccion " +
                                "LEFT JOIN tblcolonias col ON d.id_colonia = col.id_colonia " +
                                "LEFT JOIN tblcodigo_postal cp ON col.codigo_postal = cp.codigo_postal " +
                                "LEFT JOIN tblmunicipios m ON cp.id_municipio = m.id_municipio " +
                                "WHERE t.numero_control LIKE @numeroControl; ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@numeroControl", "%" + NumComtrol + "%");
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

        // Búsqueda exacta (no LIKE) para el formulario de préstamos: mismo criterio que
        // clsGestionAlumno.BuscarPorMatricula(), pero del lado de tbltrabajadores.
        public DataTable BuscarPorNumeroControl(int numeroControlBuscado)
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT t.nombre AS 'Nombre', " +
                                    "t.apellido_paterno AS 'Apellido Paterno', " +
                                    "t.apellido_materno AS 'Apellido Materno', " +
                                    "IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS 'Carrera' " +
                                "FROM tbltrabajadores t " +
                                "LEFT JOIN tblcarreras c ON t.id_carrera = c.id_carrera " +
                                "WHERE t.numero_control = @numeroControl AND t.estado = 'Activo';";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@numeroControl", numeroControlBuscado);
                        using (var adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar al trabajador: " + ex.Message);
            }
            return tabla;
        }
    }
}
