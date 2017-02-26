using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp; // Exoprtar a pdf con itextSharp - inicio
using iTextSharp.awt;
using iTextSharp.testutils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.io;
using iTextSharp.xmp; // Exoprtar a pdf con itextSharp - fin


namespace INGCIVIL
{
	/// <summary>
	/// Description of Informe.
	/// </summary>
	public class Informe
	{
		// Creamos el documento con el tamaño de página tradicional
        // ademas definimos los margenes
        public iTextSharp.text.Document doc;
        public PdfWriter writer;
        public iTextSharp.text.Font _standardFont;
        public Paragraph parrafo;
        public PdfPTable tblPrueba;
        public iTextSharp.text.Image imagen;
        public string directorio1;
        
		public Informe()
		{
			
		}
		
		public void InicializarDocumento()
		{
			this.doc = new iTextSharp.text.Document(PageSize.LETTER, 60, 30, 50, 30);
			this.writer = PdfWriter.GetInstance(doc,
                    new FileStream(directorio1,
                        FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
			// Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            this.doc.AddTitle("INFORME PDF");
            this.doc.AddCreator("COPYPRO");
			this.doc.Open(); // Abrimos el documento
		}
		public void DefinirTamanoFuenteDocumento(int tamañoLetra)
		{
			_standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 
			                                         (int)tamañoLetra,
                        							iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
		}
		public void AgregarTextoDocumento(string texto)
		{
			// Forma 1 de agregar texto:
            parrafo = new Paragraph(); //creamos un elemento parrafo
            parrafo.Alignment = Element.ALIGN_JUSTIFIED; // lo justificamos
            parrafo.Font = _standardFont; // definimos la font del parrafo
            parrafo.Add(texto); //agreagmos el texto
			doc.Add(parrafo); // añadimos el elemento tipo parrafo al documento
            AgregarSaltoLinea();
		}
		public void AgregarSaltoLinea()
		{
			this.doc.Add(new Paragraph(Environment.NewLine)); // salto de linea
		}
		public void AgregarTablaDatos(int nColumnas)
		{
			/////// Tabla inicio
			// Creamos una tabla que contendrá el nombre, apellido y país de nuestros visitante.
			tblPrueba = new PdfPTable((int)nColumnas);
			tblPrueba.WidthPercentage = 100;

			// Configuramos el tí­tulo de las columnas de la tabla
			PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
			clNombre.BorderWidth = 0;
			clNombre.BorderWidthBottom = 0.75f;

			PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
			clApellido.BorderWidth = 0;
			clApellido.BorderWidthBottom = 0.75f;

			PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
			clPais.BorderWidth = 0;
			clPais.BorderWidthBottom = 0.75f;
			
			PdfPCell clSexo = new PdfPCell(new Phrase("Sexo", _standardFont));
			clSexo.BorderWidth = 0;
			clSexo.BorderWidthBottom = 0.75f;

			// Añadimos las celdas a la tabla
			tblPrueba.AddCell(clNombre);
			tblPrueba.AddCell(clApellido);
			tblPrueba.AddCell(clPais);
			tblPrueba.AddCell(clSexo);

			// Llenamos la tabla con información - fila 1
			clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
			clNombre.BorderWidth = 0;

			clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
			clApellido.BorderWidth = 0;

			clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
			clPais.BorderWidth = 0;
			
			clSexo = new PdfPCell(new Phrase("Masculino", _standardFont));
			clSexo.BorderWidth = 0;

			// Añadimos las celdas a la tabla
			tblPrueba.AddCell(clNombre);
			tblPrueba.AddCell(clApellido);
			tblPrueba.AddCell(clPais);
			tblPrueba.AddCell(clSexo);
			
			// Llenamos la tabla con información - fila 2
			clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
			clNombre.BorderWidth = 0;

			clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
			clApellido.BorderWidth = 0;

			clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
			clPais.BorderWidth = 0;
			
			clSexo = new PdfPCell(new Phrase("Masculino", _standardFont));
			clSexo.BorderWidth = 0;

			// Añadimos las celdas a la tabla
			tblPrueba.AddCell(clNombre);
			tblPrueba.AddCell(clApellido);
			tblPrueba.AddCell(clPais);
			tblPrueba.AddCell(clSexo);
			
			// Finalmente, añadimos la tabla al documento PDF
			doc.Add(tblPrueba);
			/////// Tabla fin
		}
		public void AgregarImagen(int borde)
		{
			//Añadir imagenes
			// Creamos la imagen y le ajustamos el tamaÃ±o
			imagen = iTextSharp.text.Image.GetInstance("C:\\Users\\Usuario\\Pictures\\FACHADA PPAL.png");
			imagen.BorderWidth = borde;
			imagen.Alignment = Element.ALIGN_LEFT;
			float percentage = 0.0f;
			percentage = 480 / imagen.Width;
			imagen.ScalePercent(percentage * 100);
			// Insertamos la imagen en el documento
			doc.Add(imagen);
			AgregarSaltoLinea();
		}
		public void CerrarDocumento()
		{
			doc.Close(); // cerramos el documento
			writer.Close();
		}
		public void ExportarVarios(SaveFileDialog saveFileDialog1, iTextSharp.text.Document doc)
		{
			saveFileDialog1.Title = "Guardar Archivo PDF";
            saveFileDialog1.Filter = "Archivo de pdf (.pdf) |*.pdf";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            	
            directorio1 = saveFileDialog1.FileName;
			InicializarDocumento();// sin faltar
			DefinirTamanoFuenteDocumento(12);// sin faltar
			
			AgregarTextoDocumento("Hola mundo del itext sharp xD");
			AgregarTablaDatos(4);
			AgregarImagen(5);
			AgregarTextoDocumento("Hola mundo del itext sharp xD");
			AgregarTablaDatos(4);
			DefinirTamanoFuenteDocumento(16);
			AgregarTextoDocumento("Hola mundo del itext sharp xD");
			AgregarTablaDatos(4);
			AgregarImagen(5);
			DefinirTamanoFuenteDocumento(12);
			AgregarTextoDocumento("Hola mundo del itext sharp xD");
			AgregarTablaDatos(4);
			DefinirTamanoFuenteDocumento(24);
			AgregarTextoDocumento("Hola mundo del itext sharp xD");
			AgregarTablaDatos(4);
			DefinirTamanoFuenteDocumento(12);
			AgregarTextoDocumento("Hola mundo del itext sharp xD");
			AgregarTablaDatos(4);
			
			//
			// ejemplo de redaccion
			AgregarSaltoLinea();
			DefinirTamanoFuenteDocumento(18);
			AgregarTextoDocumento("TITULO");
			
			DefinirTamanoFuenteDocumento(14);
			AgregarTextoDocumento("SUBTITULO");
			
			DefinirTamanoFuenteDocumento(12);
			AgregarTextoDocumento("PARRAFO");
			DefinirTamanoFuenteDocumento(12);
			
			DefinirTamanoFuenteDocumento(9);
			AgregarTextoDocumento("ANOTACION");
			
			DefinirTamanoFuenteDocumento(14);
			AgregarTextoDocumento("SUBTITULO");
			
			DefinirTamanoFuenteDocumento(12);
			AgregarTextoDocumento("PARRAFO");
			DefinirTamanoFuenteDocumento(12);
			
			DefinirTamanoFuenteDocumento(12);
			AgregarTablaDatos(3);
			DefinirTamanoFuenteDocumento(9);
			AgregarTextoDocumento("ANOTACION");
			DefinirTamanoFuenteDocumento(12);
			
			DefinirTamanoFuenteDocumento(14);
			AgregarTextoDocumento("SUBTITULO");
			
			DefinirTamanoFuenteDocumento(12);
			AgregarTextoDocumento("PARRAFO");
			DefinirTamanoFuenteDocumento(12);
			
			DefinirTamanoFuenteDocumento(12);
			AgregarTablaDatos(3);
			DefinirTamanoFuenteDocumento(9);
			AgregarTextoDocumento("NOMBRE TABLA");
			DefinirTamanoFuenteDocumento(12);
			//
			//
			
			CerrarDocumento();// sin faltar
            }
		}
		public void ExportarAPdf(SaveFileDialog saveFileDialog1, iTextSharp.text.Document doc)
        {
            //          EXPORTAR PDF - METODO 1: saveFileDialog

            saveFileDialog1.Title = "Guardar Archivo PDF";
            saveFileDialog1.Filter = "Archivo de pdf (.pdf) |*.pdf";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directorio1 = saveFileDialog1.FileName;
				doc = new iTextSharp.text.Document(PageSize.LETTER, 60, 30, 50, 30);
                
                // Indicamos donde vamos a guardar el documento
                writer = PdfWriter.GetInstance(doc,
                    new FileStream(directorio1,
                        FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
                // Le colocamos el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle("INFORME PDF");
                doc.AddCreator("COPYPRO");

                doc.Open(); // Abrimos el archivo
                // Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont =
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10,
                        iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


                doc.Add(new Paragraph("", _standardFont)); // Escribimos el encabezamiento en el documento
                doc.Add(Chunk.NEWLINE); // salto de linea

                // Forma 1 de agregar texto:
                Paragraph parrafo = new Paragraph(); //creamos un elemento parrafo
                parrafo.Alignment = Element.ALIGN_JUSTIFIED; // lo justificamos
                parrafo.Font = _standardFont; // definimos la font del parrafo
                parrafo.Add(directorio1); //agreagmos el texto
                doc.Add(parrafo); // añadimos el elemento tipo parrafo al documento
                doc.Add(new Paragraph(Environment.NewLine)); // salto de linea
                
				/////// Tabla inicio
				// Creamos una tabla que contendrá el nombre, apellido y país de nuestros visitante.
				PdfPTable tblPrueba = new PdfPTable(3);
				tblPrueba.WidthPercentage = 100;

				// Configuramos el tí­tulo de las columnas de la tabla
				PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
				clNombre.BorderWidth = 0;
				clNombre.BorderWidthBottom = 0.75f;

				PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
				clApellido.BorderWidth = 0;
				clApellido.BorderWidthBottom = 0.75f;

				PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
				clPais.BorderWidth = 0;
				clPais.BorderWidthBottom = 0.75f;

				// Añadimos las celdas a la tabla
				tblPrueba.AddCell(clNombre);
				tblPrueba.AddCell(clApellido);
				tblPrueba.AddCell(clPais);

				// Llenamos la tabla con información
				clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
				clNombre.BorderWidth = 0;

				clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
				clApellido.BorderWidth = 0;

				clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
				clPais.BorderWidth = 0;

				// Añadimos las celdas a la tabla
				tblPrueba.AddCell(clNombre);
				tblPrueba.AddCell(clApellido);
				tblPrueba.AddCell(clPais);
			
				// Finalmente, añadimos la tabla al documento PDF
				doc.Add(tblPrueba);
				/////// Tabla fin

                //Añadir imagenes
				// Creamos la imagen y le ajustamos el tamaÃ±o
				iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(
															"C:\\Users\\Usuario\\Pictures\\FACHADA PPAL.png");
				imagen.BorderWidth = 0;
				imagen.Alignment = Element.ALIGN_LEFT;
				float percentage = 0.0f;
				percentage = 480 / imagen.Width;
				imagen.ScalePercent(percentage * 100);
			
				// Insertamos la imagen en el documento
				doc.Add(imagen);
			
			
				doc.Close(); // y cerramos el documento
                writer.Close();
            }

            // FIN EXPORTAR
        }
	}
}

