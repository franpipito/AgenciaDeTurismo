
using System;
using System.Collections;

namespace Parcial_AgenciaTurismo
{
	class Program
	{
		public static void Main(string[] args)
		
		{
			//Crear objeto Agencia
			Agencia a = new Agencia("Por el mundo");
			
			Console.WriteLine("Desea cargar un viaje?");
			string respuesta = Console.ReadLine();
			
			while(respuesta == "si")
			{
				Console.WriteLine("Destino");
				string destino = Console.ReadLine();
				Console.WriteLine("Codigo");
				int codigo = int.Parse(Console.ReadLine());
				Console.WriteLine("Precio");
				double precio = double.Parse(Console.ReadLine());
				Console.WriteLine("Cupo");
				int cupo = int.Parse(Console.ReadLine());
				
				//Crear objeto Viaje
				Viaje v = new Viaje(destino, codigo, precio, cupo);
				a.AgregarViaje(v);
				
				Console.WriteLine("Quiere cargar otro viaje?");
				respuesta = Console.ReadLine();
			}
			//Crear acumulador
			int pedidosTotales = 0;
			int totalRechazados = 0;
			double totalRecaudado = 0;
			
			
			Console.WriteLine("Desea comprar boleto?");
			string rta = Console.ReadLine();
			
			while(rta == "si")
			{
				Console.WriteLine("Codigo");
				int codigo = int.Parse(Console.ReadLine());
				Console.WriteLine("Dni");
				string dni = Console.ReadLine();
				Console.WriteLine("Nombre y Apellido");
				string nomyApe = Console.ReadLine();
				Console.WriteLine("Total pasajeros");
				int integrantes = int.Parse(Console.ReadLine());
				
				Viaje v = a.BuscarViaje(codigo);
				pedidosTotales++;
				
				if(v != null && v.HayCupo(integrantes))
				{
					double montoTotal = integrantes * v.Precio;
					Console.WriteLine("El monto total es: " + montoTotal);
					totalRecaudado += montoTotal;
					v.Vender(integrantes);
				}
				else
				{
					totalRechazados++;
					Console.WriteLine("Solicitud rechazada");
				}
				
				Console.WriteLine("Quieres comprar otro boleto?");
				rta = Console.ReadLine();
			}
			
			Console.WriteLine((double)totalRechazados * 100 / pedidosTotales);
			Console.WriteLine("Total reacaudado: " + totalRecaudado);
			
			//Invocacion funcion recursiva
			Console.WriteLine("Viajes menores a $250000");
			MostrarViajesBaratos(a.ListaViajes, 0);
			

			Console.ReadKey(true);
		}//fin del main
	//Definicion funcion recursiva
	public static void MostrarViajesBaratos(ArrayList listaViajes, int indice)
	{
		//caso base
		if (indice < listaViajes.Count)
		{
			//Obtener viaje en posicion actual
		Viaje v = (Viaje)listaViajes[indice];
		
		//Si cumple criterio, lo muestra
		if(v.Precio < 250000)
			Console.WriteLine("Codigo"+ v.Codigo + ", Destino" + v.Destino + ",Precio" + v.Precio);
		
		//Llamada recursiva siguiente indice
		MostrarViajesBaratos(listaViajes, indice+1);
		}
		
		
		
	}
		
		
		}
	
	}
