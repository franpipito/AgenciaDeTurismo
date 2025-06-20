using System;
using System.Collections;

namespace Parcial_AgenciaTurismo
{
	/// <summary>
	/// Description of Agencia.
	/// </summary>
	public class Agencia
	{
		//atributos
		private string nombre;
		private ArrayList listaViajes;
		
		//constructor
		public Agencia(string nombre)
		{
			this.nombre = nombre;
			listaViajes = new ArrayList();
		}
		
		//propiedades
		public string Nombre
		{
			get{return nombre;}
			set{nombre = value;}
		}
		public ArrayList ListaViajes
		{
			get{return listaViajes;}
		}
		//metodos
		public void AgregarViaje(Viaje v)
		{
			listaViajes.Add(v);
		}
		public Viaje BuscarViaje(int codigo)
		{
			foreach (Viaje v in listaViajes)
				if (v.Codigo == codigo)
					return v;
			return null;
		}
	}
}
