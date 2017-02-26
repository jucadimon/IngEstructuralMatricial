using System;
using System.Collections.Generic;

namespace INGCIVIL
{
	/// <summary>
	/// Description of columna.
	/// </summary>
	public class columna
	{
		public string nombre, resultado;
		public double ancho, altura, longitud, E, alfa, area, inercia;
		public double seno, coseno;
		public int[] gl; //grados de libertad
		public double[,] landa, klocal; //matriz rotacion y matriz de rigidez local
		public columna(string nombre, double ancho, double altura, double longitud, 
		               double moduloE, double alfa, int G1, int G2, int G3, int G4, int G5, int G6)
		{
			this.nombre = nombre;
			this.ancho = ancho;
			this.altura = altura;
			this.longitud = longitud;
			this.E = moduloE;
			this.alfa = alfa;
			this.area = ancho*altura;
			this.inercia = (ancho*Math.Pow(altura,3))/12;
			this.seno = Math.Round(Math.Sin(alfa*Math.PI/180),2);
			this.coseno = Math.Round(Math.Cos(alfa*Math.PI/180),2);
			this.gl = EstablecerGradosLibertad(G1, G2, G3, G4, G5, G6);
			this.landa = MatrizRotacion();
			this.klocal = MatrizRigidezLocal();
			this.resultado += MostrarResultadoMatriz("Matriz de Rotación", this.landa);
			this.resultado += MostrarResultadoVector("Grados de Libertad", this.gl);
			this.resultado += MostrarResultadoMatriz("Matriz de Rigidez del Elemento", this.klocal);
		}
		public int[] EstablecerGradosLibertad(int g1, int g2, int g3, int g4, int g5, int g6)
		{
			int[] GL = new int[6]
				{
				g1, g2, g3, g4, g5, g6
			}; 
			return GL;
		}
		public double[,] MatrizRotacion()
		{
			double[,] rotacion = new double[6,6]
			{
				{Math.Round(this.coseno,2),	Math.Round(this.seno,2),		0,	0,				0,				0},
				{Math.Round(-this.seno,2),	Math.Round(this.coseno,2),	0,	0,				0,				0},
				{0,				0,				1,	0,				0,				0},
				{0,				0,				0,	Math.Round(this.coseno,2),	Math.Round(this.seno,2),		0},
				{0,				0,				0,	Math.Round(-this.seno,2),		Math.Round(this.coseno,2),	0},
				{0,				0,				0,	0,				0,				1}
			};
			return rotacion;
		}
		public double[,] MatrizRigidezLocal()
		{
			double[,] rigidez = new double[6,6]
			{
				{0,	0,	0,	0,	0,	0},
				{0,	0,	0,	0,	0,	0},
				{0,	0,	0,	0,	0,	0},
				{0,	0,	0,	0,	0,	0},
				{0,	0,	0,	0,	0,	0},
				{0,	0,	0,	0,	0,	0}
			};
			
			rigidez[0,0] = Math.Round(12*this.E*this.inercia*this.seno*this.seno/(Math.Pow(this.longitud,3)) + this.area*this.E*this.coseno*this.coseno/this.longitud,2);
			rigidez[0,1] = Math.Round((-12*this.E*this.inercia/(Math.Pow(this.longitud,3)) + this.area*this.E/this.longitud)*this.coseno*this.seno,2);
			rigidez[0,2] = Math.Round(-6*this.E*this.inercia/(Math.Pow(this.longitud,2))*this.seno,2);
			
			rigidez[0,3] = Math.Round(-12*this.E*this.inercia*this.seno*this.seno/(Math.Pow(this.longitud,3)) - this.area*this.E*this.coseno*this.coseno/this.longitud,2);
			rigidez[0,4] = Math.Round((12*this.E*this.inercia/(Math.Pow(this.longitud,3)) - this.area*this.E/this.longitud)*this.coseno*this.seno,2);
			rigidez[0,5] = Math.Round(-6*this.E*this.inercia/(Math.Pow(this.longitud,2))*this.seno,2);
			                                       
			
			rigidez[1,0] = Math.Round((-12*this.E*this.inercia/(Math.Pow(this.longitud,3)) + this.area*this.E/this.longitud)*this.coseno*this.seno,2);
			rigidez[1,1] = Math.Round(12*this.E*this.inercia*this.coseno*this.coseno/(Math.Pow(this.longitud,3)) + this.area*this.E*this.seno*this.seno/this.longitud,2);
			rigidez[1,2] = Math.Round(6*this.E*this.inercia/(Math.Pow(this.longitud,2))*this.coseno,2);
			
			rigidez[1,3] = Math.Round((12*this.E*this.inercia/(Math.Pow(this.longitud,3)) - this.area*this.E/this.longitud)*this.coseno*this.seno,2);
			rigidez[1,4] = Math.Round(-12*this.E*this.inercia*this.coseno*this.coseno/(Math.Pow(this.longitud,3)) - this.area*this.E*this.seno*this.seno/this.longitud,2);
			rigidez[1,5] = Math.Round(6*this.E*this.inercia/(Math.Pow(this.longitud,2))*this.coseno,2);
			                                                                                                      
			                                                                                                      
			rigidez[2,0] = Math.Round((-6*this.E*this.inercia/(Math.Pow(this.longitud,2)))*this.seno,2);
			rigidez[2,1] = Math.Round((6*this.E*this.inercia/(Math.Pow(this.longitud,2)))*this.coseno,2);
			rigidez[2,2] = Math.Round(4*this.E*this.inercia/(Math.Pow(this.longitud,1)),2);
			
			rigidez[2,3] = Math.Round((6*this.E*this.inercia/(Math.Pow(this.longitud,2)))*this.seno,2);
			rigidez[2,4] = Math.Round((-6*this.E*this.inercia/(Math.Pow(this.longitud,2)))*this.coseno,2);
			rigidez[2,5] = Math.Round(2*this.E*this.inercia/(Math.Pow(this.longitud,1)),2);
			
			rigidez[3,0] = Math.Round(-12*this.E*this.inercia*this.seno*this.seno/(Math.Pow(this.longitud,3)) - this.area*this.E*this.coseno*this.coseno/this.longitud,2);
			rigidez[3,1] = Math.Round((12*this.E*this.inercia/(Math.Pow(this.longitud,3)) - this.area*this.E/this.longitud)*this.coseno*this.seno,2);
			rigidez[3,2] = Math.Round(6*this.E*this.inercia/(Math.Pow(this.longitud,2))*this.seno,2);
			
			rigidez[3,3] = rigidez[0,0];
			rigidez[3,4] = rigidez[0,1];
			rigidez[3,5] = rigidez[2,3];//
			
			rigidez[4,0] = rigidez[0,4];
			rigidez[4,1] = rigidez[1,4];
			rigidez[4,2] = rigidez[2,4];
			
			rigidez[4,3] = rigidez[0,1];
			rigidez[4,4] = rigidez[1,1];
			rigidez[4,5] = rigidez[2,4];
			
			rigidez[5,0] = rigidez[2,0];
			rigidez[5,1] = rigidez[1,2];
			rigidez[5,2] = rigidez[2,5];
			
			rigidez[5,3] = rigidez[2,3];
			rigidez[5,4] = rigidez[2,4];
			rigidez[5,5] = rigidez[2,2];
			                                                                             			                                                                                                                                                                                                                         
			return rigidez;
		}
		public string  MostrarResultadoVector(string nombreVector, int[] vec)
		{
			string twd = "";
			twd += "\r\n";
			twd += "\r\n"+nombreVector+":";
			twd += "\r\n";
			for (int i = 0; i < vec.Length ; i++) {
				
				twd += "    "+vec[i]+";";
			}
			return twd;
		}
		public string MostrarResultadoMatriz(string nombreMatriz, double[,] mat)
		{
			string twd = "";
			twd += "\r\n";
			twd += "\r\n"+nombreMatriz+":";
			for (int i = 0; i < mat.GetLength(0); i++) 
			{
				twd += "\r\n";
				for (int j = 0; j < mat.GetLength(1); j++) 
				{
					twd += "    "+mat[i,j]+";";
				}
			}
			return twd;
		}
		public  override string ToString()
    	{
			return string.Format("Elemento {0}: " +
			                     "\r\nAncho: {1:G3} m " +
			                     "\r\nAlto: {2:G3} m" +
			                     "\r\nLongitud: {3:G3} m" +
			                     "\r\nE: {4:G6} KN/m2" +
			                     "\r\nAngulo: {5:G3} º" +
			                     "\r\nArea: {6:G6} m2" +
			                     "\r\nInerciaa: {7:G6} m4" +
			                     "\r\nSeno: {8:G6}" +
			                     "\r\nCoseno: {9:G6}" +
			                     resultado
			                     , nombre, ancho, altura, longitud, E, alfa, area, inercia, seno, coseno);
    	}
	}
}
