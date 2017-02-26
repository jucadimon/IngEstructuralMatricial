using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace INGCIVIL
{
	/// <summary>
	/// Description of geometria.
	/// </summary>
	public class geometria
	{
		/*
		 * alias es el nombre que identifica la geometria
		 * lx es la distancia en la direcciòn x 
		 * ly es la distancia en la direcciòn y
		 * lz es la distancia en la direcciòn z
		 *xi es la coordenada 3D inicial del vector que representa el eje que pasa por el centroide en el plano YZ
		 *yi es la coordenada 3D inicial del vector que representa el eje que pasa por el centroide en el plano XZ
		 *zi es la coordenada 3D inicial del vector que representa el eje que pasa por el centroide en el plano XY
		 * xf es la coordenada 3D final del vector que representa el eje que pasa por el centroide en el plano YZ
		 * yf es la coordenada 3D final del vector que representa el eje que pasa por el centroide en el plano XZ
		 * zf es la coordenada 3D final del vector que representa el eje que pasa por el centroide en el plano XY
		 */
		private string alias;
		private double lx, ly, lz, xi, yi, zi, xf, yf, zf;
		private double areaXY, areaXZ, areaYZ, areaSuperficial;
		private double centroideXY, centroideXZ, centroideYZ;
		private double volumen;
		public geometria()
		{
		}
		public geometria(string alias, 
		                double lx, double ly, double lz,
		                double xi, double yi, double zi,
		                double xf, double yf, double zf)
		{
			this.alias=alias;
			this.lx=lx;
			this.ly=ly;
			this.lz=lz;
			this.xi=xi;
			this.yi=yi;
			this.zi=zi;
			this.xf=xf;
			this.yf=yf;
			this.zf=zf;
		}
		private string Alias()
		{
			return alias;
		}
		private double longitud_x()
		{
			return lx=Math.Abs(xf-xi);
		}
		private double longitud_y()
		{
			return ly=Math.Abs(yf-yi);
		}
		private double longitud_z()
		{
			return lz=Math.Abs(zf-zi);
		}
		private double AreaXY()
		{
			return areaXY=Math.Abs(lx*ly);
		}
		private double AreaXZ()
		{
			return areaXY=Math.Abs(lx*lz);
		}
		private double AreaYZ()
		{
			return areaXY=Math.Abs(ly*lz);
		}
		private double Volumen()
		{
			return volumen=Math.Abs(lx*ly*lz);
		}
		private void Dibujar_Geometria(PictureBox pbox)
		{
			pbox.CreateGraphics();
			
		}
	}
}
