using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
//Agregar los using de la libreria QuestPDF
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace prySistema_prestamos_libros
{
    internal class clsReportes
    {
        DataTable tabla;
        MySqlDataAdapter consulta;
        public DataTable LibrosMasSolicitadosPorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Agregamos la columna 'Total General del Libro' usando una Window Function de MySQL.
                    // Cambiamos el nombre de la columna individual a 'Préstamos por Carrera' para que sea más claro.
                    string sql = @"
                                    SELECT 
                                        COALESCE(ca.nombre_carrera, ct.nombre_carrera, 'Sin Carrera / Administrativo') AS 'Carrera', 
                                        l.titulo_libro AS 'Libro', 
                                        COUNT(p.id_prestamo) AS 'Préstamos por Carrera',
                                        SUM(COUNT(p.id_prestamo)) OVER(PARTITION BY l.id_libro) AS 'Total General del Libro'
                                    FROM tblprestamos p 
                                    INNER JOIN tblejemplares e ON p.id_ejemplar = e.id_ejemplar 
                                    INNER JOIN tbllibros l ON e.id_libro = l.id_libro 
                                    LEFT JOIN tblalumnos a ON a.matricula = p.matricula 
                                    LEFT JOIN tbltrabajadores t ON t.numero_control = p.numero_control 
                                    LEFT JOIN tblcarreras ca ON a.id_carrera = ca.id_carrera 
                                    LEFT JOIN tblcarreras ct ON t.id_carrera = ct.id_carrera 
                                    WHERE DATE(p.fecha_prestamo) BETWEEN @fechaInicio AND @fechaFin 
                                    AND DAYOFWEEK(p.fecha_prestamo) BETWEEN 2 AND 6 
                                    AND l.id_libro IN (
                                        SELECT top_libros.id_libro FROM (
                                            SELECT e_sub.id_libro
                                            FROM tblprestamos p_sub
                                            INNER JOIN tblejemplares e_sub ON p_sub.id_ejemplar = e_sub.id_ejemplar
                                            WHERE DATE(p_sub.fecha_prestamo) BETWEEN @fechaInicio AND @fechaFin
                                            AND DAYOFWEEK(p_sub.fecha_prestamo) BETWEEN 2 AND 6
                                            GROUP BY e_sub.id_libro
                                            ORDER BY COUNT(p_sub.id_prestamo) DESC
                                            LIMIT 3
                                        ) AS top_libros
                                    )
                                    GROUP BY 
                                        COALESCE(ca.nombre_carrera, ct.nombre_carrera, 'Sin Carrera / Administrativo'), 
                                        l.id_libro, 
                                        l.titulo_libro 
                                    ORDER BY 
                                        SUM(COUNT(p.id_prestamo)) OVER(PARTITION BY l.id_libro) DESC, 
                                        l.titulo_libro ASC, 
                                        COUNT(p.id_prestamo) DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"));

                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los libros más solicitados por fecha: " + ex.Message);
            }
            return tabla;
        }


        public DataTable ConsultarLibrosVencidos(DateTime fechaInicio, DateTime fechaFin)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT COALESCE(CONCAT(A.nombre, ' ', A.apellido_paterno, ' ', A.apellido_materno), " +
                                 "CONCAT(T.nombre, ' ', T.apellido_paterno, ' ', T.apellido_materno)) AS Solicitante, " +
                                 "CASE WHEN P.matricula IS NOT NULL THEN 'Alumno' ELSE 'Trabajador' END AS Tipo, " +
                                 "COALESCE(A.telefono, T.telefono) AS Telefono, " +
                                 "P.matricula AS Matricula, " +
                                 "P.numero_control AS 'Numero de Control', " +
                                 "L.titulo_libro AS 'Titulo del Libro', " +
                                 "P.fecha_prestamo AS 'Fecha de Préstamo', " +
                                 "P.fecha_devolucion AS 'Fecha en que Venció', " +
                                 "DATEDIFF(CURRENT_DATE(), P.fecha_devolucion) AS 'Días de Atraso' " +
                                 "FROM tblprestamos P " +
                                 "LEFT JOIN tblalumnos A ON A.matricula = P.matricula " +
                                 "LEFT JOIN tbltrabajadores T ON T.numero_control = P.numero_control " +
                                 "INNER JOIN tblejemplares E ON E.id_ejemplar = P.id_ejemplar " +
                                 "INNER JOIN tbllibros L ON L.id_libro = E.id_libro " +
                                 "WHERE P.fecha_devolucion_real IS NULL " +
                                 "AND P.fecha_devolucion < CURRENT_DATE() " +
                                 "AND DATE(P.fecha_prestamo) BETWEEN @fechaInicio AND @fechaFin " +
                                 "ORDER BY P.fecha_prestamo ASC;"; 

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"));

                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los libros vencidos: " + ex.Message);
            }
            return tabla;
        }

        public DataTable LibrosPrestadosEnSemana(DateTime fechaInicio, DateTime fechaFin)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Usamos BETWEEN para el rango de fechas
                    // Y DAYOFWEEK para filtrar solo de Lunes (2) a Viernes (6)
                    string sql = "SELECT DATE(p.fecha_prestamo) AS 'Fecha', " +
                                 "l.titulo_libro AS 'Libro', " +
                                 "c.nombre AS 'Categoría', " +
                                 "COUNT(p.id_prestamo) AS 'Libros Prestados' " +
                                 "FROM tblprestamos p " +
                                 "INNER JOIN tblejemplares e ON p.id_ejemplar = e.id_ejemplar " +
                                 "INNER JOIN tbllibros l ON e.id_libro = l.id_libro " +
                                 "INNER JOIN tblcategorias c ON l.id_categoria = c.id_categoria " +
                                 "WHERE DATE(p.fecha_prestamo) BETWEEN @fechaInicio AND @fechaFin " +
                                 "AND DAYOFWEEK(p.fecha_prestamo) BETWEEN 2 AND 6 " +
                                 "GROUP BY DATE(p.fecha_prestamo), l.titulo_libro, c.nombre " +
                                 "ORDER BY `Fecha` ASC, `Libros Prestados` ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        // Asignamos los parámetros de fecha
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"));

                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los libros prestados en la semana: " + ex.Message);
            }
            return tabla;
        }

        public DataTable DisponibilidadTotalLibros()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT l.titulo_libro AS 'Libro', " +
                                    "COUNT(e.id_ejemplar) AS 'Total de Ejemplares', " +
                                    "SUM(CASE WHEN EXISTS (" +
                                        "SELECT 1 FROM tblprestamos p " +
                                        "WHERE p.id_ejemplar = e.id_ejemplar " +
                                        "AND p.fecha_devolucion_real IS NULL" +
                                    ") THEN 1 ELSE 0 END) AS 'Prestados', " +
                                    "COUNT(e.id_ejemplar) - SUM(CASE WHEN EXISTS (" +
                                        "SELECT 1 FROM tblprestamos p " +
                                        "WHERE p.id_ejemplar = e.id_ejemplar " +
                                        "AND p.fecha_devolucion_real IS NULL" +
                                    ") THEN 1 ELSE 0 END) AS 'Disponibles' " +
                                "FROM tbllibros l " +
                                "INNER JOIN tblejemplares e ON l.id_libro = e.id_libro " +
                                "WHERE e.estado = 'Activo' " +
                                "GROUP BY l.id_libro, l.titulo_libro " +
                                "ORDER BY l.titulo_libro; ";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las categorias mas solicitadas al mes: " + ex.Message);
            }
            return tabla;
        }

        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            if(tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            //abre la ventana para guardar el archivo pdf
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.Letter.Landscape());
                            page.Margin(1.5f, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontFamily(Fonts.Arial));

                            //esto es para poner un titulo al reporte
                            page.Header().Row(row =>
                            {
                                row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                                {
                                    col.Item().Text("LIBRARY MANAGER")
                                    .FontSize(18)
                                    .Bold()
                                    .FontColor("#10407A");
                                    col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                                });

                                if (Properties.Resources.Diseño_sin_título__7_ != null)
                                {
                                    byte[] bytesLogo = ConvertirBitmapABytes(Properties.Resources.Diseño_sin_título__7_);
                                    row.ConstantItem(90).AlignRight().AlignMiddle().Image(bytesLogo);
                                }
                            });

                            // --- PARTE 2: CONTENIDO CENTRAL ---
                            page.Content().PaddingTop(20).Column(column =>
                            {
                                // AQUÍ SE IMPRIME EL TÍTULO QUE LE PASES POR PARÁMETRO
                                column.Item().PaddingBottom(15).Text(tituloReporte) // <-- DINÁMICO
                                    .FontSize(12).Bold().FontColor(Colors.Black);

                                // Subtítulo con la fecha exacta de generación del reporte
                                column.Item().PaddingBottom(15).Text("Fecha de generación: " + DateTime.Now.ToString("dd/MM/yyyy"))
                                    .FontSize(10).FontColor(Colors.Grey.Darken2);

                                // La tabla se construye sola según las columnas que traiga el DataTable
                                column.Item().Table(table =>
                                {
                                    int totalColumnas = tabla.Columns.Count;

                                    table.ColumnsDefinition(columns =>
                                    {
                                        for (int i = 0; i < totalColumnas; i++)
                                        {
                                            if (i > 0 && i < totalColumnas - 1)
                                                columns.RelativeColumn(2f);
                                            else
                                                columns.RelativeColumn(1.2f);
                                        }
                                    });

                                    // Nombres de las columnas en automatico de acuerdo a la tabla
                                    foreach (DataColumn columnaObj in tabla.Columns)
                                    {
                                        table.Cell().Background("#4272CB").Padding(8).AlignLeft().AlignMiddle()
                                            .Text(columnaObj.ColumnName).FontSize(10).Bold().FontColor(Colors.White);
                                    }

                                    // Filas automáticas
                                    bool alternarFila = true;
                                    foreach (DataRow fila in tabla.Rows)
                                    {
                                        string colorFondo = alternarFila ? "#E6EBF5" : "#FFFFFF";

                                        for (int i = 0; i < totalColumnas; i++)
                                        {
                                            var celda = table.Cell().Background(colorFondo)
                                                .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                .Padding(7).AlignMiddle();

                                            if (i == 0 || i == (totalColumnas - 1))
                                                celda.AlignCenter();
                                            else
                                                celda.AlignLeft();
                                            object valor = fila[i];
                                            string textoMostrar = "";

                                            if (valor is DateTime fecha)
                                            {
                                                // Muestra únicamente la fecha en formato día/mes/año sin hora
                                                textoMostrar = fecha.ToString("dd/MM/yyyy");
                                            }
                                            else
                                            {
                                                textoMostrar = valor.ToString();
                                            }

                                            celda.Text(textoMostrar).FontSize(9).FontColor(Colors.Black);
                                        }

                                        alternarFila = !alternarFila;
                                    }
                                });
                            });

                            // Este es el pie de página
                            page.Footer().AlignRight().Text(x =>
                            {
                                x.Span("Página ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.CurrentPageNumber().FontSize(9).Bold();
                                x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.TotalPages().FontSize(9).Bold();
                            });
                        });
                    })
                    .GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Properties.Resources genera las imágenes como Bitmap, pero QuestPDF necesita
        // un arreglo de bytes para .Image(...); esta conversión pasa de uno a otro.
        private byte[] ConvertirBitmapABytes(System.Drawing.Bitmap bitmap)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
