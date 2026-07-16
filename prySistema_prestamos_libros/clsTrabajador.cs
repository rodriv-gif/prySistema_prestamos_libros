using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsTrabajador : clsDatosPersona
    {
        private int numeroControl;
        private int idCarrera;
        private string estado;

        public int NumeroControl { get => numeroControl; set => numeroControl = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Estado { get => estado; set => estado = value; }

        // Registra un trabajador nuevo. Son 2 inserts (direccion, luego trabajador) porque
        // tbltrabajadores.id_direccion depende de que la fila de tbldireccion ya exista.
        // Van dentro de una transacción: si el segundo insert falla, se deshace el primero
        // y no queda una dirección huérfana sin trabajador.
        public string RegistrarTrabajador()
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
                            // Insertar la dirección y obtener el id_direccion que genera
                            int idDireccionNueva = 0;

                            string sqlDireccion = @"INSERT INTO tbldireccion (id_colonia, calle)
                                                     VALUES (@idColonia, @calle);
                                                     SELECT LAST_INSERT_ID();";

                            using (var comandoDireccion = new MySqlCommand(sqlDireccion, conexion, transaccion))
                            {
                                comandoDireccion.Parameters.AddWithValue("@idColonia", this.IdColonia);
                                comandoDireccion.Parameters.AddWithValue("@calle", this.Calle);
                                idDireccionNueva = Convert.ToInt32(comandoDireccion.ExecuteScalar()); //recuperamos el id de la direccion recien insertada
                            }

                            // Insertar el trabajador usando el id_direccion recién creado
                            string sqlTrabajador = @"INSERT INTO tbltrabajadores
                                                     (numero_control, id_carrera, nombre, apellido_paterno, apellido_materno, id_direccion, email, telefono, estado, fecha_registro)
                                                     VALUES (@numControl, @idCarrera, @nombre, @apPaterno, @apMaterno, @idDireccion, @email, @telefono, @estado, @fecha);";

                            using (var comandoTrabajador = new MySqlCommand(sqlTrabajador, conexion, transaccion))
                            {
                                comandoTrabajador.Parameters.AddWithValue("@numControl", this.NumeroControl);
                                comandoTrabajador.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
                                comandoTrabajador.Parameters.AddWithValue("@nombre", this.Nombre);
                                comandoTrabajador.Parameters.AddWithValue("@apPaterno", this.ApellidoPaterno);
                                comandoTrabajador.Parameters.AddWithValue("@apMaterno", this.ApellidoMaterno);
                                comandoTrabajador.Parameters.AddWithValue("@idDireccion", idDireccionNueva);
                                comandoTrabajador.Parameters.AddWithValue("@email", this.Correo);
                                comandoTrabajador.Parameters.AddWithValue("@telefono", this.Telefono);
                                comandoTrabajador.Parameters.AddWithValue("@estado", this.Estado);
                                comandoTrabajador.Parameters.AddWithValue("@fecha", this.FechaRegistro);
                                comandoTrabajador.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msj = "El trabajador se registró correctamente";
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

        /* Actualiza un trabajador existente. Igual que RegistrarTrabajador(), toca 2 tablas
        tbldireccion y tbltrabajadores) dentro de una transacción, pero con UPDATE en vez
        de INSERT porque las filas ya existen.
        idDireccion, id_direccion que ya tenía el trabajador (para saber qué fila de tbldireccion actualizar).
        numeroControlOriginal: numero_control que tenía ANTES de la edición (para el WHERE),
        por si el usuario lo cambió en el formulario.*/
        public string ActualizarTrabajador(int idDireccion, int numeroControlOriginal)
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

                            string sqlTrabajador = @"UPDATE tbltrabajadores
                                                     SET numero_control = @numControl,
                                                         id_carrera = @idCarrera,
                                                         nombre = @nombre,
                                                         apellido_paterno = @apPaterno,
                                                         apellido_materno = @apMaterno,
                                                         email = @email,
                                                         telefono = @telefono,
                                                         estado = @estado
                                                     WHERE numero_control = @numControlOriginal;";

                            using (var comandoTrabajador = new MySqlCommand(sqlTrabajador, conexion, transaccion))
                            {
                                comandoTrabajador.Parameters.AddWithValue("@numControl", this.NumeroControl);
                                comandoTrabajador.Parameters.AddWithValue("@idCarrera", this.IdCarrera);
                                comandoTrabajador.Parameters.AddWithValue("@nombre", this.Nombre);
                                comandoTrabajador.Parameters.AddWithValue("@apPaterno", this.ApellidoPaterno);
                                comandoTrabajador.Parameters.AddWithValue("@apMaterno", this.ApellidoMaterno);
                                comandoTrabajador.Parameters.AddWithValue("@email", this.Correo);
                                comandoTrabajador.Parameters.AddWithValue("@telefono", this.Telefono);
                                comandoTrabajador.Parameters.AddWithValue("@estado", this.Estado);
                                comandoTrabajador.Parameters.AddWithValue("@numControlOriginal", numeroControlOriginal);
                                comandoTrabajador.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msj = "El trabajador se actualizó correctamente";
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

        // Baja lógica: no borra la fila, solo marca estado = 'Inactivo'. Así el registro
        // se puede recuperar después y no rompe referencias de otras tablas (préstamos, etc.).
        public string DarBajaTrabajador(int numeroControl)
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tbltrabajadores SET estado = 'Inactivo' WHERE numero_control = @numControl;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@numControl", numeroControl);
                        comando.ExecuteNonQuery();
                    }
                }
                msj = "El trabajador se dio de baja correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja al trabajador: " + ex.Message);
            }

            return msj;
        }

        // Catálogo puro de Carreras/Áreas para el combo del formulario.
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
