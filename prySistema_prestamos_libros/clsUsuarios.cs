using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsUsuarios
    {
        clsConexion conexion = new clsConexion();

        public int IdBibliotecario { get; set; }
        public int IdPerfil { get; set; }
        public int NumeroControl { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

      
        public DataTable CargarDataGrid()
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT
                                    b.id_bibliotecario,
                                    t.numero_control,
                                    CONCAT(t.nombre,' ',t.apellido_paterno,' ',t.apellido_materno) AS Nombre,
                                    p.perfil,
                                    b.usuario
                                   FROM tblbibliotecario b
                                   INNER JOIN tbltrabajadores t
                                   ON b.numero_control = t.numero_control
                                   INNER JOIN tblperfil p
                                   ON b.id_perfil = p.id_perfil
                                   ORDER BY t.numero_control";

                MySqlDataAdapter da = new MySqlDataAdapter(consulta, cn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios.\n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return dt;
        }

       
        public DataTable BuscarTrabajador(int numeroControl)
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT
                                    numero_control,
                                    nombre,
                                    apellido_paterno,
                                    apellido_materno,
                                    id_carrera
                                   FROM tbltrabajadores
                                   WHERE numero_control=@numero";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@numero", numeroControl);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return dt;
        }

        public DataTable CargarPerfiles
        {
            get
            {
                DataTable dt = new DataTable();

                MySqlConnection cn = null;

                try
                {
                    cn = conexion.AbrirConexion();

                    string consulta = @"SELECT
                                    id_perfil,
                                    perfil
                                   FROM tblperfil";

                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, cn);

                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion(cn);
                }

                return dt;
            }
        }

        public object? Contrasena { get; private set; }

        public bool ExisteUsuario(string usuario)
        {
            bool existe = false;

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT COUNT(*)
                                    FROM tblbibliotecario
                                    WHERE usuario=@usuario";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                existe = cantidad > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return existe;
        }
       
        public bool GuardarUsuario()
        {
            bool resultado = false;

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"INSERT INTO tblbibliotecario
                            (id_perfil,
                             numero_control,
                             usuario,
                             contrasenia)
                            VALUES
                            (@idPerfil,
                             @NumControl,
                             @Usuario,
                             @Contrasena)";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@idPerfil", IdPerfil);
                cmd.Parameters.AddWithValue("@NumControl", NumeroControl);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@contrasena", Contrasena);

                resultado = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario.\n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return resultado;
        }

        
        public bool EditarUsuario()
        {
            bool resultado = false;

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"UPDATE tblbibliotecario
                            SET
                            id_perfil=@idPerfil,
                            usuario=@Usuario,
                            contrasena=@contrasena
                            WHERE id_bibliotecario=@idBibliotecario";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@idPerfil", IdPerfil);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contrasenia", Contrasenia);
                cmd.Parameters.AddWithValue("@idBibliotecario", IdBibliotecario);

                resultado = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el usuario.\n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return resultado;
        }


        public DataTable BuscarUsuario(int idBibliotecario)
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT
                            b.id_bibliotecario,
                            b.numero_control,
                            b.id_perfil,
                            b.usuario,
                            b.contrasenia,
                            t.nombre,
                            t.apellido_paterno,
                            t.apellido_materno,
                            t.id_carrera
                            FROM tblbibliotecario b
                            INNER JOIN tbltrabajadores t
                            ON b.numero_control=t.numero_control
                            WHERE b.id_bibliotecario=@id";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@id", idBibliotecario);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return dt;
        }


        public DataTable BuscarGrid(string numeroControl)
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT
                            b.id_bibliotecario,
                            t.numero_control,
                            CONCAT(t.nombre,' ',t.apellido_paterno,' ',t.apellido_materno) AS Nombre,
                            p.nombre_perfil,
                            b.usuario
                            FROM tblbibliotecario b
                            INNER JOIN tbltrabajadores t
                            ON b.numero_control=t.numero_control
                            INNER JOIN tblperfil p
                            ON b.id_perfil=p.id_perfil
                            WHERE t.numero_control LIKE @numero";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@numero", "%" + numeroControl + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return dt;
        }
        public DataTable CargarPerfil()
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT
                            id_perfil,
                            id_perfil
                            FROM tblperfil
                            ORDER BY nombre_perfil";

                MySqlDataAdapter da = new MySqlDataAdapter(consulta, cn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return dt;
        }
    }
}
