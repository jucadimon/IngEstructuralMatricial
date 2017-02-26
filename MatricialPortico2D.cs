using System;

namespace INGCIVIL
{
	/// <summary>
	/// Description of MatricialPortico2D.
	/// </summary>
	public class MatricialPortico2D
	{
		public string nombrePortico, resultados;
		public int numeroElementosMatrizGlobal, glMatrizGlobal;
		public columna[] elementos;
		public double[] FuerzasDirectasEnNodos, FuerzasActuantesElementosPI, FuerzasTotalesPII;
		public double[,] matrizGlobal;
		
		public MatricialPortico2D(string nombrePortico, int numeroElementos, columna[] elementos)
		{
			this.nombrePortico = nombrePortico;
			this.numeroElementosMatrizGlobal = numeroElementos;
			this.elementos = elementos;//aqui un metodo que reciba la matriz de elementos
		}
		
	}
}
