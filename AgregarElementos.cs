using System;
using System.Drawing;
using System.Windows.Forms;

namespace INGCIVIL
{
	/// <summary>
	/// Description of AgregarElementos.
	/// </summary>
	public partial class AgregarElementos : Form
	{
		public AgregarElementos()
		{
			InitializeComponent();
		}
		
		void BtnCalcularElementoClick(object sender, EventArgs e)
		{
			CalcularElemento(rtbox_resumen);
		}
		public void CalcularElemento(RichTextBox rt)
		{
			columna col = new columna(tbox_nombre.Text, 
			                          Convert.ToDouble(tbox_ancho.Text), 
			                          Convert.ToDouble(tbox_alto.Text), 
			                          Convert.ToDouble(tbox_longitud.Text), 
			                          Convert.ToDouble(tbox_moduloE.Text), 
			                          Convert.ToDouble(tbox_angulo.Text), 
			                          Convert.ToInt16(tbox_g1.Text), 
			                          Convert.ToInt16(tbox_g2.Text),
			                          Convert.ToInt16(tbox_g3.Text),
			                          Convert.ToInt16(tbox_g4.Text),
			                          Convert.ToInt16(tbox_g5.Text),
			                          Convert.ToInt16(tbox_g6.Text));

			rt.Text += "\r\n \r\n";
			rt.Text += col.ToString();
		}
		
		public void CrearPDFDesdeRichTexbox(RichTextBox rt)
		{
			Informe infx = new Informe();
			infx.directorio1 ="";
			saveFileDialog1.Title = "Guardar Archivo PDF";
            saveFileDialog1.Filter = "Archivo de pdf (.pdf) |*.pdf";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            	
            infx.directorio1 = saveFileDialog1.FileName;
			infx.InicializarDocumento();
			infx.DefinirTamanoFuenteDocumento(10);
			infx.AgregarTextoDocumento(rt.Text);
			infx.CerrarDocumento();
            }
		}
		
		void BtnExportarPDfClick(object sender, EventArgs e)
		{
			CrearPDFDesdeRichTexbox(rtbox_resumen);
		}
		
		void Btn_exportarPDfClick(object sender, EventArgs e)
		{
			CrearPDFDesdeRichTexbox(rtbox_resumenportico);
		}
	}
}
