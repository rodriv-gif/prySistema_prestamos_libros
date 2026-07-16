using MySqlConnector;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsAlumnos : clsDatosPersona
    {
        private int matricula;
        private int idCarrera;
        private int grado;
        private string grupo;
        private string estado;

        // matricula es INT en tblalumnos (PRIMARY KEY), no texto.
        public int Matricula { get => matricula; set => matricula = value; }
        public int Grado { get => grado; set => grado = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Estado { get => estado; set => estado = value; }

        // Registra un alumno nuevo. Son 2 inserts (direccion, luego alumno), igual que en
        // clsTrabajador.Registrar(), porque tblalumnos.id_direccion depende de que la fila
        // de tbldireccion ya exista. Van dentro de una transacción para que si el segundo
        // insert falla, se deshaga el primero.
        public string Registrar()
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1) Insertar la dirección y obtener el id_direccion que genera
                            int idDireccionNueva = 0;

                            string sqlDireccion = @"INSERT INTO tbldireccion (id_colonia, calle)
                                                     VALUES (@idColonia, @calle);
                                                     SELECT LAST_INSERT_ID();";

                            using (var comandoDireccion = new MySqlCommand(sqlDireccion, conexion, transaccion))
                            {
                                comandoDireccion.Parameters.AddWithValue("@idColonia", this.IdColonia);
                                comandoDireccion.Parameters.AddWithValue("@calle", this.Calle);
                                idDireccionNueva = Convert.ToInt32(comandoDireccion.ExecuteScalar());
                            }

                            // 2) Insertar el alumno usando el id_direccion recién creado
                            string sqlAlumno = @"INSERT INTO tblalumnos
                                                 (matricula, id_carrera, nombre, apellido_paterno, apellido_materno, id_direccion, email, telefono, grado, grupo, fecha_registro, estado)
                                                 VALUES (@mat, @idCar, @nom, @apP, @apM, @idDireccion, @email, @tel, @gra, @gru, @fecha, @estado);";

                            using (var comandoAlumno = new MySqlCommand(sqlAlumno, conexion, transaccion))
                            {
                                comandoAlumno.Parameters.AddWithValue("@mat", this.Matricula);
                                comandoAlumno.Parameters.AddWithValue("@idCar", this.IdCarrera);
                                comandoAlumno.Parameters.AddWithValue("@nom", this.Nombre);
                                comandoAlumno.Parameters.AddWithValue("@apP", this.ApellidoPaterno);
                                comandoAlumno.Parameters.AddWithValue("@apM", this.ApellidoMaterno);
                                comandoAlumno.Parameters.AddWithValue("@idDireccion", idDireccionNueva);
                                comandoAlumno.Parameters.AddWithValue("@email", this.Correo);
                                comandoAlumno.Parameters.AddWithValue("@tel", this.Telefono);
                                comandoAlumno.Parameters.AddWithValue("@gra", this.Grado);
                                comandoAlumno.Parameters.AddWithValue("@gru", this.Grupo);
                                comandoAlumno.Parameters.AddWithValue("@fecha", this.FechaRegistro);
                                comandoAlumno.Parameters.AddWithValue("@estado", this.Estado);
                                comandoAlumno.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msj = "El alumno se registró correctamente";
                        }
                        catch(Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en la BD: " + ex.Message);
            }

            return msj;
        }

        // Método para cargar el catálogo puro de Carreras en el ComboBox del formulario
        public DataTable ObtenerCarreras()
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_carrera, nombre_carrera FROM tblcarreras;";
                    using (var consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar carreras: " + ex.Message);
            }
            return tabla;
        }
    }
}
