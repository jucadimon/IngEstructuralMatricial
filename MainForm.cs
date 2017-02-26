using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace INGCIVIL
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1MouseClick(object sender, MouseEventArgs e)
		{
			//no
		}
		
		void Btn_limpiarMouseClick(object sender, MouseEventArgs e)
		{
			//no
		}
		
		void Btn_cargar_datosClick(object sender, EventArgs e)
		{
			AgregarElementos ae = new AgregarElementos();
			ae.Show();
		}
		
		void Btn_mostrarClick(object sender, EventArgs e)
		{
			
			string micol = "Elemento1";
			columna col = new columna(micol, 0.35, 0.35, 3.4, 20000000, 90, 1, 2,3,7,8,9);
			
			txt_nombre.Text += "\r\n";
			txt_nombre.Text += col.ToString();
//			
//			txt_nombre.Text += "\r\nMatriz de Rotación:";
//			for (int i = 0; i < col.landa.GetLength(0); i++)
//			{
//				txt_nombre.Text += "\r\n";
//				for (int j = 0; j < col.landa.GetLength(1); j++) 
//				{
//					txt_nombre.Text += "    "+col.landa[i,j]+";";
//				}
//			}
//			
//			txt_nombre.Text += "\r\nGrados de Libertad:";
//			txt_nombre.Text += "\r\n";
//			for (int i = 0; i <= 5; i++) {
//				
//				txt_nombre.Text += "    "+col.gl[i]+";";
//			}
//			
//			txt_nombre.Text += "\r\nMatriz de Rigidez del Elemento:";
//			for (int k = 0; k <= 5; k++) 
//			{
//				txt_nombre.Text += "\r\n";
//				for (int l = 0; l <= 5; l++) 
//				{
//					txt_nombre.Text += "    "+col.klocal[k,l]+";";
//				}
//			}
			
			CrearPDFDesdeCajaTexto(txt_nombre);
			
		}
		public void CrearPDFDesdeCajaTexto(TextBox txbox)
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
			infx.AgregarTextoDocumento((string)txbox.Text);
			infx.CerrarDocumento();
            }
		}
		void Btn_limpiarClick(object sender, EventArgs e)
		{
			txt_nombre.Text="";
			txt_lx.Text="";
			txt_ly.Text="";
			txt_lz.Text="";
			txt_xi.Text="";
			txt_yi.Text="";
			txt_zi.Text="";
			txt_xf.Text="";
			txt_yf.Text="";
			txt_zf.Text="";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Informe inf = new Informe();
			///inf.ExportarAPdf(saveFileDialog1, inf.doc);
			inf.ExportarVarios(saveFileDialog1, inf.doc);
		}
	}
}
