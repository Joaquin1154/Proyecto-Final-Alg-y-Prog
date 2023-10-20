/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/5/2023
 * Hora: 14:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Constructora
{
	/// <summary>
	/// Clase Obrero.
	/// </summary>
	public class Obrero
	{
		//Atributos de la clase
		private string Nombre;
		private string Apellido;
		private int Dni;
		private int Legajo;
		private string Cargo;
		private int Grupo;
		
		//Constructores
		public Obrero(){}
		
		public Obrero(string nombre, string apellido, int dni, int legajo, string cargo, int grupo){
			
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Dni = dni;
			this.Legajo = legajo;
			this.Cargo = cargo;
			this.Grupo = grupo;
			
		}
		
		public Obrero(string nombre, string apellido, int dni, int legajo, string cargo){
			
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Dni = dni;
			this.Legajo = legajo;
			this.Cargo = cargo;
			
		}
		
		//Propiedades
		public string NOMBRE{
		
			get { return this.Nombre; }
			set { this.Nombre = value; }
		
		}
		public string APELLIDO{
			
			get { return this.Apellido; }
			set { this.Apellido = value; }
			
		}
		
		public int DNI{
			
			get { return this.Dni; }
			set { this.Dni = value; }
			
		}
		
		public int LEGAJO{
			
			get { return this.Legajo; }
			set { this.Legajo = value; }
			
		}
		
		public string CARGO{
			
			get { return this.Cargo; }
			set { this.Cargo = value; }
			
		}
		
		public int GRUPO{
			
			get { return this.Grupo; }
			set { this.Grupo = value; }
			
		}
		
		// Métodos
	    public void ImprimirNombre()
	{
	    Console.WriteLine("Nombre: {0}", Nombre);
	}
	
	public void ModificarNombre(string nuevoNombre)
	{
	    this.Nombre = nuevoNombre;
	}
	
	public void ImprimirApellido()
	{
	    Console.WriteLine("Apellido: {0}", Apellido);
	}
	
	public void ModificarApellido(string nuevoApellido)
	{
	    this.Apellido = nuevoApellido;
	}
	
	public void ImprimirDni()
	{
	    Console.WriteLine("DNI: {0}", Dni);
	}
	
	public void ModificarDni(int nuevoDni)
	{
	    this.Dni = nuevoDni;
	}
	
	public void ImprimirLegajo()
	{
	    Console.WriteLine("Legajo: {0}", Legajo);
	}
	
	public void ModificarLegajo(int nuevoLegajo)
	{
	    this.Legajo = nuevoLegajo;
	}
	
	public void ImprimirCargo()
	{
	    Console.WriteLine("Cargo: {0}", Cargo);
	}
	
	public void ModificarCargo(string nuevoCargo)
	{
	    this.Cargo = nuevoCargo;
	}
	
	public void ImprimirGrupo()
	{
	    Console.WriteLine("Grupo: {0}", Grupo);
	}
	
	public void ModificarGrupo(int nuevoGrupo)
	{
	    this.Grupo = nuevoGrupo;
	}

		
	}

}
