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

        private int numeroControl;
        private int idPerfil;
        private int idBibliotecario;

        private string usuario;
        private string contrasena;


        public int NumeroControl { get => numeroControl; set => numeroControl = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public int IdBibliotecario { get => idBibliotecario; set => idBibliotecario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }


        public DataTable CargarPerfiles()
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();


                string consulta = @"SELECT 
                                    id_perfil,
                                    Perfil
                                    FROM tblperfil
                                    ORDER BY Perfil";


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

        public DataTable BuscarTrabajador(int numeroControl)
        {

            DataTable dt = new DataTable();

            MySqlConnection cn = null;


            try
            {

                cn = conexion.AbrirConexion();


                string consulta = @"SELECT
                                    t.numero_control,
                                    t.nombre,
                                    t.apellido_paterno,
                                    t.apellido_materno,
                                    IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS nombre_carrera
                                    FROM tbltrabajadores t
                                    LEFT JOIN tblcarreras c ON t.id_carrera = c.id_carrera
                                    WHERE t.numero_control = @numero_control";


                MySqlCommand cmd = new MySqlCommand(consulta, cn);


                cmd.Parameters.AddWithValue("@numero_control", numeroControl);



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
        public bool ExisteUsuario(string usuario)
        {
            bool existe = false;

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();


                string consulta = @"SELECT COUNT(*) 
                            FROM tblbibliotecario
                            WHERE usuario = @usuario";


                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue(
                    "@usuario",
                    usuario);


                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());


                if (cantidad > 0)
                {
                    existe = true;
                }

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

        // Revisa si el trabajador ya tiene un usuario/bibliotecario asignado, para no dejar registrar dos.
        public bool ExisteBibliotecarioParaTrabajador(int numeroControl)
        {
            bool existe = false;

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @"SELECT COUNT(*)
                            FROM tblbibliotecario
                            WHERE numero_control = @numero_control";

                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@numero_control", numeroControl);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                if (cantidad > 0)
                {
                    existe = true;
                }
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
                            (
                                numero_control,
                                id_perfil,
                                usuario,
                                contrasenia
                            )
                            VALUES
                            (
                                @numero_control,
                                @id_perfil,
                                @usuario,
                                @contrasenia
                            )";


                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@numero_control", NumeroControl);
                cmd.Parameters.AddWithValue("@id_perfil", IdPerfil);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contrasenia", Contrasena);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    resultado = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


                // La contraseña no se actualiza aquí por seguridad; solo Perfil y Usuario.
                string consulta = @"UPDATE tblbibliotecario
                            SET
                                id_perfil = @id_perfil,
                                usuario = @usuario
                            WHERE id_bibliotecario = @id_bibliotecario";


                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@id_perfil", IdPerfil);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@id_bibliotecario", IdBibliotecario);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    resultado = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                            t.nombre,
                            t.apellido_paterno,
                            t.apellido_materno,
                            IFNULL(c.nombre_carrera, 'Sin Carrera / Administrativo') AS nombre_carrera,
                            b.usuario,
                            b.contrasenia,
                            b.id_perfil
                            FROM tblbibliotecario b
                            INNER JOIN tbltrabajadores t
                            ON b.numero_control = t.numero_control
                            LEFT JOIN tblcarreras c
                            ON t.id_carrera = c.id_carrera
                            WHERE b.id_bibliotecario = @id";


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
        public DataTable CargarUsuarios()
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;

            try
            {
                cn = conexion.AbrirConexion();


                // Nombre/apellidos van dos veces: concatenados para mostrar, y ocultos por si se necesitan.
                string consulta = @"
                                    SELECT
                                        b.id_bibliotecario AS 'ID Bibliotecario',
                                        b.numero_control AS 'Número de Control',
                                        CONCAT(t.nombre, ' ', t.apellido_paterno, ' ', t.apellido_materno) AS 'Nombre completo',
                                        t.nombre AS 'Nombre',
                                        t.apellido_paterno AS 'Apellido Paterno',
                                        t.apellido_materno AS 'Apellido Materno',
                                        p.Perfil AS 'Perfil',
                                        b.usuario AS 'Usuario'
                                    FROM tblbibliotecario b

                                    INNER JOIN tbltrabajadores t
                                    ON b.numero_control = t.numero_control

                                    INNER JOIN tblperfil p
                                    ON b.id_perfil = p.id_perfil

                                    ORDER BY t.nombre";

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
        public DataTable BuscarUsuarios(string texto)
        {
            DataTable dt = new DataTable();

            MySqlConnection cn = null;


            try
            {
                cn = conexion.AbrirConexion();

                string consulta = @" SELECT
                                        b.id_bibliotecario AS 'ID Bibliotecario',
                                        b.numero_control AS 'Número de Control',
                                        CONCAT(t.nombre, ' ', t.apellido_paterno, ' ', t.apellido_materno) AS 'Nombre completo',
                                        t.nombre AS 'Nombre',
                                        t.apellido_paterno AS 'Apellido Paterno',
                                        t.apellido_materno AS 'Apellido Materno',
                                        p.Perfil AS 'Perfil',
                                        b.usuario AS 'Usuario'

                                    FROM tblbibliotecario b

                                    INNER JOIN tbltrabajadores t
                                    ON b.numero_control = t.numero_control

                                    INNER JOIN tblperfil p
                                    ON b.id_perfil = p.id_perfil


                                    WHERE 
                                    b.numero_control LIKE @texto
                                    OR t.nombre LIKE @texto
                                    OR t.apellido_paterno LIKE @texto
                                    OR b.usuario LIKE @texto";


                MySqlCommand cmd = new MySqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
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

        public bool DarBaja(int idBibliotecario)
        {
            bool resultado = false;


            MySqlConnection cn = null;


            try
            {

                cn = conexion.AbrirConexion();


                string consulta = @"
                                    DELETE FROM tblbibliotecario
                                    WHERE id_bibliotecario = @id";


                MySqlCommand cmd = new MySqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@id", idBibliotecario);

                int filas = cmd.ExecuteNonQuery();



                if (filas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }

            return resultado;
        }

    }
}
