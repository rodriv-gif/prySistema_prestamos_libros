using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace prySistema_prestamos_libros
{
    // Clase de escritura para préstamos (INSERT + catálogos para llenar combos), igual
    // que clsTrabajador/clsAlumnos: el "Registrar" vive aquí, no en una clsGestionPrestamo.
    internal class clsPrestamo
    {
        // Catálogo para cmbTipoPrestamo (Biblioteca / Domicilio).
        public DataTable ObtenerTiposPrestamo()
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_tipo_prestamo, tipo FROM tbltipo_prestamo;";
                    using (var adaptador = new MySqlDataAdapter(sql, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los tipos de préstamo: " + ex.Message);
            }
            return tabla;
        }

        // Catálogo para cmbEstadoPrestamo (Pendiente / Devuelto / Vencido).
        public DataTable ObtenerEstadosPrestamo()
        {
            DataTable tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_estado, estado FROM tblestado_prestamo;";
                    using (var adaptador = new MySqlDataAdapter(sql, conexion))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los estados de préstamo: " + ex.Message);
            }
            return tabla;
        }

        // Registra un préstamo por cada ejemplar en el carrito (idsEjemplares), todos con
        // los mismos datos generales (solicitante, tipo, fechas, estado, bibliotecario).
        // Solo uno de matricula/numeroControl debe traer valor; el otro se manda NULL,
        // según si el solicitante es Alumno o Trabajador.
        public string RegistrarPrestamo(int? matricula, int? numeroControl, int idTipoPrestamo,
            int idEstadoPrestamo, DateTime fechaPrestamo, DateTime fechaDevolucion,
            int idBibliotecario, List<int> idsEjemplares)
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
                            string sqlInsertar = @"INSERT INTO tblprestamos
                                (id_bibliotecario, id_ejemplar, matricula, numero_control,
                                 id_tipo_prestamo, id_estado_prestamo, fecha_prestamo, fecha_devolucion)
                                VALUES (@idBibliotecario, @idEjemplar, @matricula, @numeroControl,
                                @idTipoPrestamo, @idEstadoPrestamo, @fechaPrestamo, @fechaDevolucion);";

                            foreach (int idEjemplar in idsEjemplares)
                            {
                                using (var comando = new MySqlCommand(sqlInsertar, conexion, transaccion))
                                {
                                    comando.Parameters.AddWithValue("@idBibliotecario", idBibliotecario);
                                    comando.Parameters.AddWithValue("@idEjemplar", idEjemplar);
                                    comando.Parameters.AddWithValue("@matricula", (object)matricula ?? DBNull.Value);
                                    comando.Parameters.AddWithValue("@numeroControl", (object)numeroControl ?? DBNull.Value);
                                    comando.Parameters.AddWithValue("@idTipoPrestamo", idTipoPrestamo);
                                    comando.Parameters.AddWithValue("@idEstadoPrestamo", idEstadoPrestamo);
                                    comando.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
                                    comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                                    comando.ExecuteNonQuery();
                                }
                            }

                            transaccion.Commit();
                            msj = "Se registraron " + idsEjemplares.Count + " préstamo(s) correctamente";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
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
    }
}
