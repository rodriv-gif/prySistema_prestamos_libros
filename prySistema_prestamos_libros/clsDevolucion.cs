using MySqlConnector;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsDevolucion
    {
         // 1. Método para obtener préstamos pendientes
        public DataTable ObtenerPrestamosPendientes(int idSolicitante)
        {
            DataTable dt = new DataTable();
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string consulta = @"
                SELECT 
                    p.id_prestamo,
                    l.titulo_libro AS 'Título',
                    p.fecha_prestamo AS 'Fecha Préstamo',
                    p.fecha_devolucion AS 'Fecha Límite',
                    IF(CURRENT_DATE() > p.fecha_devolucion, DATEDIFF(CURRENT_DATE(), p.fecha_devolucion), 0) AS 'Días Retraso'
                FROM tblprestamos p
                INNER JOIN tblejemplares e ON p.id_ejemplar = e.id_ejemplar
                INNER JOIN tbllibros l ON e.id_libro = l.id_libro
                WHERE (p.matricula = " + idSolicitante + @" OR p.numero_control = " + idSolicitante + @")
                  AND p.fecha_devolucion_real IS NULL;";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar préstamos: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion(conexion);
            }

            return dt;
        }

        // Marca el libro como devuelto; solo toca fecha_devolucion_real, nunca fecha_devolucion.
        public bool DevolverLibro(int idPrestamo, DateTime fechaDevolucionReal, int idEstadoPrestamo)
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string sql = @"
                UPDATE tblprestamos
                SET fecha_devolucion_real = @fechaReal,
                    id_estado_prestamo = @idEstado
                WHERE id_prestamo = @idPrestamo;";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@fechaReal", fechaDevolucionReal.Date);
                cmd.Parameters.AddWithValue("@idEstado", idEstadoPrestamo);
                cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la devolución: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion(conexion);
            }
        }

        // Registra la multa; nace 'Pendiente' o 'Pagado' si pagadaDeInmediato=true.
        public bool GuardarMulta(int idPrestamo, decimal monto, string motivo, int diasAtrasados,
                                  bool pagadaDeInmediato, DateTime? fechaPago)
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string estadoPago = pagadaDeInmediato ? "Pagado" : "Pendiente";

            string sql = @"
                INSERT INTO tblmultas (id_prestamo, monto, motivo, dias_atrasados, estado_pago, fecha_pago)
                VALUES (@idPrestamo, @monto, @motivo, @dias, @estadoPago, @fechaPago);";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@dias", diasAtrasados);
                cmd.Parameters.AddWithValue("@estadoPago", estadoPago);
                cmd.Parameters.AddWithValue("@fechaPago", (object)fechaPago?.Date ?? DBNull.Value);
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la multa: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion(conexion);
            }
        }

        // Trae las multas pendientes de visitas anteriores de ese solicitante.
        public DataTable ObtenerMultasPendientes(int idSolicitante)
        {
            DataTable dt = new DataTable();
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string sql = @"
                SELECT m.id_multa,
                       l.titulo_libro AS 'Título',
                       m.motivo AS 'Motivo',
                       m.monto AS 'Monto',
                       m.dias_atrasados AS 'Días Atrasados'
                FROM tblmultas m
                INNER JOIN tblprestamos p ON m.id_prestamo = p.id_prestamo
                INNER JOIN tblejemplares e ON p.id_ejemplar = e.id_ejemplar
                INNER JOIN tbllibros l ON e.id_libro = l.id_libro
                WHERE (p.matricula = @idSolicitante OR p.numero_control = @idSolicitante)
                  AND m.estado_pago = 'Pendiente';";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@idSolicitante", idSolicitante);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las multas pendientes: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion(conexion);
            }

            return dt;
        }

        // Marca como 'Pagado' una multa; se llama una vez por cada renglón palomeado.
        public bool RegistrarPagoMulta(int idMulta, DateTime fechaPago)
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string sql = @"
                UPDATE tblmultas
                SET estado_pago = 'Pagado', fecha_pago = @fechaPago
                WHERE id_multa = @idMulta;";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@fechaPago", fechaPago.Date);
                cmd.Parameters.AddWithValue("@idMulta", idMulta);
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago de la multa: " + ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion(conexion);
            }
        }
    }
}
