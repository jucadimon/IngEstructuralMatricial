/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 14/11/2016
 * Time: 23:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace INGCIVIL
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btn_cargar_datos = new System.Windows.Forms.Button();
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.pbox = new System.Windows.Forms.PictureBox();
			this.gbox = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_limpiar = new System.Windows.Forms.Button();
			this.btn_mostrar = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_zf = new System.Windows.Forms.TextBox();
			this.txt_yf = new System.Windows.Forms.TextBox();
			this.txt_xf = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_zi = new System.Windows.Forms.TextBox();
			this.txt_yi = new System.Windows.Forms.TextBox();
			this.txt_xi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_lz = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_ly = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_lx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
			this.gbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_cargar_datos
			// 
			this.btn_cargar_datos.BackColor = System.Drawing.Color.White;
			this.btn_cargar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cargar_datos.ForeColor = System.Drawing.Color.DimGray;
			this.btn_cargar_datos.Location = new System.Drawing.Point(49, 170);
			this.btn_cargar_datos.Name = "btn_cargar_datos";
			this.btn_cargar_datos.Size = new System.Drawing.Size(98, 23);
			this.btn_cargar_datos.TabIndex = 0;
			this.btn_cargar_datos.Text = "cargar datos";
			this.btn_cargar_datos.UseVisualStyleBackColor = false;
			this.btn_cargar_datos.Click += new System.EventHandler(this.Btn_cargar_datosClick);
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_resultado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(12, 245);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(306, 188);
			this.lbl_resultado.TabIndex = 1;
			this.lbl_resultado.Text = ".";
			// 
			// pbox
			// 
			this.pbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbox.Cursor = System.Windows.Forms.Cursors.Cross;
			this.pbox.Location = new System.Drawing.Point(326, 245);
			this.pbox.Name = "pbox";
			this.pbox.Size = new System.Drawing.Size(286, 188);
			this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbox.TabIndex = 2;
			this.pbox.TabStop = false;
			// 
			// gbox
			// 
			this.gbox.Controls.Add(this.button1);
			this.gbox.Controls.Add(this.btn_limpiar);
			this.gbox.Controls.Add(this.btn_mostrar);
			this.gbox.Controls.Add(this.label8);
			this.gbox.Controls.Add(this.label9);
			this.gbox.Controls.Add(this.txt_zf);
			this.gbox.Controls.Add(this.btn_cargar_datos);
			this.gbox.Controls.Add(this.txt_yf);
			this.gbox.Controls.Add(this.txt_xf);
			this.gbox.Controls.Add(this.label10);
			this.gbox.Controls.Add(this.label6);
			this.gbox.Controls.Add(this.label5);
			this.gbox.Controls.Add(this.txt_zi);
			this.gbox.Controls.Add(this.txt_yi);
			this.gbox.Controls.Add(this.txt_xi);
			this.gbox.Controls.Add(this.label7);
			this.gbox.Controls.Add(this.txt_nombre);
			this.gbox.Controls.Add(this.label4);
			this.gbox.Controls.Add(this.txt_lz);
			this.gbox.Controls.Add(this.label3);
			this.gbox.Controls.Add(this.txt_ly);
			this.gbox.Controls.Add(this.label2);
			this.gbox.Controls.Add(this.txt_lx);
			this.gbox.Controls.Add(this.label1);
			this.gbox.Location = new System.Drawing.Point(13, 12);
			this.gbox.Name = "gbox";
			this.gbox.Size = new System.Drawing.Size(599, 230);
			this.gbox.TabIndex = 3;
			this.gbox.TabStop = false;
			this.gbox.Text = "Propiedades";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.DimGray;
			this.button1.Location = new System.Drawing.Point(49, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "generar informe";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btn_limpiar
			// 
			this.btn_limpiar.BackColor = System.Drawing.Color.White;
			this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_limpiar.ForeColor = System.Drawing.Color.DimGray;
			this.btn_limpiar.Location = new System.Drawing.Point(153, 199);
			this.btn_limpiar.Name = "btn_limpiar";
			this.btn_limpiar.Size = new System.Drawing.Size(103, 23);
			this.btn_limpiar.TabIndex = 23;
			this.btn_limpiar.Text = "limpiar";
			this.btn_limpiar.UseVisualStyleBackColor = false;
			this.btn_limpiar.Click += new System.EventHandler(this.Btn_limpiarClick);
			this.btn_limpiar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_limpiarMouseClick);
			// 
			// btn_mostrar
			// 
			this.btn_mostrar.BackColor = System.Drawing.Color.White;
			this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_mostrar.ForeColor = System.Drawing.Color.DimGray;
			this.btn_mostrar.Location = new System.Drawing.Point(153, 170);
			this.btn_mostrar.Name = "btn_mostrar";
			this.btn_mostrar.Size = new System.Drawing.Size(105, 23);
			this.btn_mostrar.TabIndex = 22;
			this.btn_mostrar.Text = "mostrar datos";
			this.btn_mostrar.UseVisualStyleBackColor = false;
			this.btn_mostrar.Click += new System.EventHandler(this.Btn_mostrarClick);
			this.btn_mostrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_limpiarMouseClick);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(185, 140);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "zf";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(185, 117);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "yf";
			// 
			// txt_zf
			// 
			this.txt_zf.Location = new System.Drawing.Point(221, 137);
			this.txt_zf.Name = "txt_zf";
			this.txt_zf.Size = new System.Drawing.Size(37, 20);
			this.txt_zf.TabIndex = 19;
			// 
			// txt_yf
			// 
			this.txt_yf.Location = new System.Drawing.Point(221, 114);
			this.txt_yf.Name = "txt_yf";
			this.txt_yf.Size = new System.Drawing.Size(37, 20);
			this.txt_yf.TabIndex = 18;
			// 
			// txt_xf
			// 
			this.txt_xf.Location = new System.Drawing.Point(221, 91);
			this.txt_xf.Name = "txt_xf";
			this.txt_xf.Size = new System.Drawing.Size(37, 20);
			this.txt_xf.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(185, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 23);
			this.label10.TabIndex = 16;
			this.label10.Text = "xf";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(102, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "zi";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(102, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "yi";
			// 
			// txt_zi
			// 
			this.txt_zi.Location = new System.Drawing.Point(138, 137);
			this.txt_zi.Name = "txt_zi";
			this.txt_zi.Size = new System.Drawing.Size(37, 20);
			this.txt_zi.TabIndex = 13;
			// 
			// txt_yi
			// 
			this.txt_yi.Location = new System.Drawing.Point(138, 114);
			this.txt_yi.Name = "txt_yi";
			this.txt_yi.Size = new System.Drawing.Size(37, 20);
			this.txt_yi.TabIndex = 11;
			// 
			// txt_xi
			// 
			this.txt_xi.Location = new System.Drawing.Point(138, 91);
			this.txt_xi.Name = "txt_xi";
			this.txt_xi.Size = new System.Drawing.Size(37, 20);
			this.txt_xi.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(102, 94);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "xi";
			// 
			// txt_nombre
			// 
			this.txt_nombre.AcceptsReturn = true;
			this.txt_nombre.AcceptsTab = true;
			this.txt_nombre.Location = new System.Drawing.Point(59, 19);
			this.txt_nombre.Multiline = true;
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_nombre.Size = new System.Drawing.Size(520, 66);
			this.txt_nombre.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "nombre";
			// 
			// txt_lz
			// 
			this.txt_lz.Location = new System.Drawing.Point(59, 137);
			this.txt_lz.Name = "txt_lz";
			this.txt_lz.Size = new System.Drawing.Size(37, 20);
			this.txt_lz.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "long. z (m)";
			// 
			// txt_ly
			// 
			this.txt_ly.Location = new System.Drawing.Point(59, 114);
			this.txt_ly.Name = "txt_ly";
			this.txt_ly.Size = new System.Drawing.Size(37, 20);
			this.txt_ly.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "long. y (m)";
			// 
			// txt_lx
			// 
			this.txt_lx.Location = new System.Drawing.Point(59, 91);
			this.txt_lx.Name = "txt_lx";
			this.txt_lx.Size = new System.Drawing.Size(37, 20);
			this.txt_lx.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "long. x (m)";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.gbox);
			this.Controls.Add(this.pbox);
			this.Controls.Add(this.lbl_resultado);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "INGCIVIL";
			((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
			this.gbox.ResumeLayout(false);
			this.gbox.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_lx;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_ly;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_lz;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_xi;
		private System.Windows.Forms.TextBox txt_yi;
		private System.Windows.Forms.TextBox txt_zi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_xf;
		private System.Windows.Forms.TextBox txt_yf;
		private System.Windows.Forms.TextBox txt_zf;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_mostrar;
		private System.Windows.Forms.Button btn_limpiar;
		private System.Windows.Forms.GroupBox gbox;
		private System.Windows.Forms.PictureBox pbox;
		private System.Windows.Forms.Label lbl_resultado;
		private System.Windows.Forms.Button btn_cargar_datos;
	}
}
