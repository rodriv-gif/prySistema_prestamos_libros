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

        //Método para marcar el libro como devuelto
        public bool DevolverLibro(int idPrestamo)
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string sql = @"
                UPDATE tblprestamos 
                SET fecha_devolucion_real = CURRENT_DATE(), 
                    id_estado_prestamo = 2 
                WHERE id_prestamo = " + idPrestamo + ";";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
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

        // Método para registrar la multa si hubo retraso
        public bool GuardarMulta(int idPrestamo, decimal monto, string motivo, int diasAtrasados, string fechaPago)
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string sql = @"
                INSERT INTO tblmultas (id_prestamo, monto, motivo, fecha_pago, dias_atrasados)
                VALUES (" + idPrestamo + ", " + monto.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", '" + motivo + "', '" + fechaPago + "', " + diasAtrasados + ");";

            try
            {
                conexion = conexionBD.AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
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
    }
}
