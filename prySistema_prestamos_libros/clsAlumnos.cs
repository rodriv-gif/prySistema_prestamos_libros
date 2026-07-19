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


        public int Matricula { get => matricula; set => matricula = value; }
        public int Grado { get => grado; set => grado = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Estado { get => estado; set => estado = value; }

        // Registra un alumno nuevo. Son 2 inserts (direccion, luego alumno), igual que en
        // clsTrabajador.Registrar(), porque tblalumnos.id_direccion depende de que la fila
        // de tbldireccion ya exista. Van dentro de una transacción para que si el segundo
        // insert falla, se deshaga el primero.
        public string RegistrarAlumno()
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
                                                 VALUES (@matricula, @idCarrera, @nombre, @apP, @apM, @idDireccion, @email, @tel, @grado, @grupo, @fecha, @estado);";

                            using (var comandoAlumno = new MySqlCommand(sqlAlumno, conexion, transaccion))
                            {
                                comandoAlumno.Parameters.AddWithValue("@matricula", this.Matricula);
                                comandoAlumno.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
                                comandoAlumno.Parameters.AddWithValue("@nombre", this.Nombre);
                                comandoAlumno.Parameters.AddWithValue("@apP", this.ApellidoPaterno);
                                comandoAlumno.Parameters.AddWithValue("@apM", this.ApellidoMaterno);
                                comandoAlumno.Parameters.AddWithValue("@idDireccion", idDireccionNueva);
                                comandoAlumno.Parameters.AddWithValue("@email", this.Correo);
                                comandoAlumno.Parameters.AddWithValue("@tel", this.Telefono);
                                comandoAlumno.Parameters.AddWithValue("@grado", this.Grado);
                                comandoAlumno.Parameters.AddWithValue("@grupo", this.Grupo);
                                comandoAlumno.Parameters.AddWithValue("@fecha", this.FechaRegistro);
                                comandoAlumno.Parameters.AddWithValue("@estado", this.Estado);
                                comandoAlumno.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msj = "El alumno se registró correctamente";
                        }
                        catch (Exception ex)
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

        /* Actualiza un alumno existente. Igual que RegistrarAlumno(), toca 2 tablas
        tbldireccion y tblalumnos) dentro de una transacción, pero con UPDATE en vez
        de INSERT porque las filas ya existen.
        idDireccion, id_direccion que ya tenía el trabajador (para saber qué fila de tbldireccion actualizar).
        matriculaOriginal: matricula que tenía ANTES de la edición (para el WHERE),
        por si el usuario lo cambió en el formulario.*/
        public string ActualizarAlumno(int idDireccion, int matriculaOriginal)
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
                            string sqlDireccion = @"UPDATE tbldireccion
                                                     SET id_colonia = @idColonia, calle = @calle
                                                     WHERE id_direccion = @idDireccion;";

                            using (var comandoDireccion = new MySqlCommand(sqlDireccion, conexion, transaccion))
                            {
                                comandoDireccion.Parameters.AddWithValue("@idColonia", this.IdColonia);
                                comandoDireccion.Parameters.AddWithValue("@calle", this.Calle);
                                comandoDireccion.Parameters.AddWithValue("@idDireccion", idDireccion);
                                comandoDireccion.ExecuteNonQuery();
                            }

                            string sqlAlumno = @"UPDATE tblalumnos
                                                     SET matricula = @matricula,
                                                         id_carrera = @idCarrera,
                                                         nombre = @nombre,
                                                         apellido_paterno = @apP,
                                                         apellido_materno = @apM,
                                                         email = @email,
                                                         telefono = @tel,
                                                         grado = @grado,
                                                         grupo = @grupo,
                                                         fecha_registro = @fecha,
                                                         estado = @estado
                                                     WHERE matricula = @matriculaOriginal;";

                            using (var comandoAlumno = new MySqlCommand(sqlAlumno, conexion, transaccion))
                            {
                                comandoAlumno.Parameters.AddWithValue("@matricula", this.Matricula);
                                comandoAlumno.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
                                comandoAlumno.Parameters.AddWithValue("@nombre", this.Nombre);
                                comandoAlumno.Parameters.AddWithValue("@apP", this.ApellidoPaterno);
                                comandoAlumno.Parameters.AddWithValue("@apM", this.ApellidoMaterno);
                                comandoAlumno.Parameters.AddWithValue("@email", this.Correo);
                                comandoAlumno.Parameters.AddWithValue("@tel", this.Telefono);
                                comandoAlumno.Parameters.AddWithValue("@grado", this.Grado);
                                comandoAlumno.Parameters.AddWithValue("@grupo", this.Grupo);
                                comandoAlumno.Parameters.AddWithValue("@fecha", this.FechaRegistro);
                                comandoAlumno.Parameters.AddWithValue("@estado", this.Estado);
                                comandoAlumno.Parameters.AddWithValue("@matriculaOriginal", matriculaOriginal);
                                comandoAlumno.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msj = "El alumno se actualizó correctamente";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar en la BD: " + ex.Message);
            }

            return msj;
        }

        /* Baja lógica: no borra la fila, solo marca estado = 'Inactivo'. Así el registro
         se puede recuperar después y no rompe referencias de otras tablas (préstamos, etc.).*/
        public string DarBajaAlumno(int matricula)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tblalumnos SET estado = 'Inactivo' WHERE matricula = @matricula;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@matricula", matricula);
                        comando.ExecuteNonQuery();
                    }
                }
                msj = "El alumno se dio de baja correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja al alumno: " + ex.Message);
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
