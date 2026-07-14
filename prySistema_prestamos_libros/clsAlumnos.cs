using MySqlConnector;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace prySistema_prestamos_libros
{
    internal class clsAlumnos : clsDatosPersona
    {
        private string matricula;
        private int idCarrera;
        private int grado;
        private string grupo;

        public string Matricula { get => matricula; set => matricula = value; }
        public int Grado { get => grado; set => grado = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

        //Metodo para registrar un nuevo alumno
        public string Registrar()
        {
            string msj = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //Insertar datos
                    string sqlInsAlumno = @"INSERT INTO alumnos(matricula, id_carrera, nombre, apellido_paterno, apellido_materno, calle, colonia, cp, email, telefono, grado, grupo, fecha_registro) 
                                      VALUES(@mat, @idCar, @nom, @apP, @apM, @calle, @col, @cp, @email, @tel, @gra, @gru, @fecha);";
                    using (var comando = new MySqlCommand(sqlInsAlumno, conexion))
                    {
                        //llenamos los parametros de sql con las propiedades
                        comando.Parameters.AddWithValue("@mat", this.Matricula);
                        comando.Parameters.AddWithValue("@idCar", this.IdCarrera);
                        comando.Parameters.AddWithValue("@nom", this.Nombre);
                        comando.Parameters.AddWithValue("@apP", this.ApellidoPaterno);
                        comando.Parameters.AddWithValue("@apP", this.ApellidoMaterno);
                        comando.Parameters.AddWithValue("@calle", this.Calle);
                        comando.Parameters.AddWithValue("@col", this.Colonia);
                        comando.Parameters.AddWithValue("@cp", this.CodigoPostal);
                        comando.Parameters.AddWithValue("@email", this.Correo);
                        comando.Parameters.AddWithValue("@tel", this.Telefono);
                        comando.Parameters.AddWithValue("@gra", this.Grado);
                        comando.Parameters.AddWithValue("@gru", this.Grupo);
                        comando.Parameters.AddWithValue("@fecha", this.FechaRegistro);

                        //Se ejecuta la consulta
                        comando.ExecuteNonQuery();
                    }
                    msj = "El alumno se registró correctamente";

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al guardar en la BD; " + ex.Message);
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
