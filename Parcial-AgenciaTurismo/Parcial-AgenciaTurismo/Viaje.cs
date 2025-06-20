
using System;
using System.Collections;

namespace Parcial_AgenciaTurismo
{
	/// <summary>
	/// Description of Viaje.
	/// </summary>
	public class Viaje
	{
		//atributos
		private string destino;
		private int codigo;
		private double precio;
		private int cupo;
		private ArrayList listaPasajeros;
		
		//constructor
		public Viaje(string destino, int codigo, double precio, int cupo)
		{
			this.destino = destino;
			this.codigo = codigo;
			this.precio = precio;
			this.cupo = cupo;
			listaPasajeros = new ArrayList();
		}
		//propiedades
		public string Destino
		{
			get{return destino;}
			set{destino = value;}
		}
		public int Codigo
		{
			get{return codigo;}
			set{codigo = value;}
		}
		public double Precio
		{
			get{return precio;}
			set{precio = value;}
		}
		public int Cupo
		{
			get{return cupo;}
			set{cupo = value;}
		}
		public ArrayList ListaPasajeros
		{
			get{return listaPasajeros;}
		}
		//metodos
		public bool HayCupo(int cantidad)
		{
			return cupo >= cantidad;
		}
		public void Vender(int cantidad)
		{
			cupo -= cantidad;
		}
		
		
	}

}