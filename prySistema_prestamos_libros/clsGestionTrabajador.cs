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
                    // Se trae el registro completo
                    // para que al editar no se necesite una segunda consulta a la base de datos.
                    // id_carrera va al final y se oculta en la grid, solo sirve para preseleccionar el combo al editar.
                    string sql = "SELECT t.numero_control AS 'Número de Control', " +
                                    "t.nombre AS 'Nombre', " +
                                    "t.apellido_paterno AS 'Apellido Paterno', " +
                                    "t.apellido_materno AS 'Apellido Materno', " +
                                    "t.calle AS 'Calle', " +
                                    "t.colonia AS 'Colonia', " +
                                    "t.codigo_postal AS 'Código Postal', " +
                                    "IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS 'Carrera', " +
                                    "t.email AS 'Correo electrónico', " +
                                    "t.telefono AS 'Teléfono', " +
                                    "t.estado AS 'Estatus', " +
                                    "t.fecha_registro AS 'Fecha de Registro', " +
                                    "t.id_carrera AS 'id_carrera' " +
                                "FROM tbltrabajadores t " +
                                "LEFT JOIN tblcarreras c ON t.id_carrera = c.id_carrera; ";

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
                                    "t.nombre AS 'Nombre', " +
                                    "t.apellido_paterno AS 'Apellido Paterno', " +
                                    "t.apellido_materno AS 'Apellido Materno', " +
                                    "t.calle AS 'Calle', " +
                                    "t.colonia AS 'Colonia', " +
                                    "t.codigo_postal AS 'Código Postal', " +
                                    "IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS 'Carrera', " +
                                    "t.email AS 'Correo electrónico', " +
                                    "t.telefono AS 'Teléfono', " +
                                    "t.estado AS 'Estatus', " +
                                    "t.fecha_registro AS 'Fecha de Registro', " +
                                    "t.id_carrera AS 'id_carrera'  " +
                                "FROM tbltrabajadores t " +
                                "LEFT JOIN tblcarreras c ON t.id_carrera = c.id_carrera " +
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
    }
}
