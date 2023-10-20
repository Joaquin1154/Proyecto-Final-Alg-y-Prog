/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/5/2023
 * Hora: 14:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Constructora
{
	/// <summary>
	/// Clase Obra.
	/// </summary>
	public class Obra
	{
		//Atributos de la clase
		private string NombrePropietario;
		private string ApellidoPropietario;
		private int DniPropietario;
		private int Codigo;
		private string Tipo;
		private string TiempoEstimado;
		private int GrupoAsignado;
		private string Avance;
		private float Costo;
		
		//Constructores
		public Obra(){}
		
		public Obra(string nom, string ape, int dni, int cod, string tipo, int grupo, string avance, float costo, string tiempo){
			
			this.NombrePropietario = nom;
			this.ApellidoPropietario = ape;
			this.DniPropietario = dni;
			this.Codigo = cod;
			this.Tipo = tipo;
			this.GrupoAsignado = grupo;
			this.Avance = avance;
			this.Costo = costo;
			this.TiempoEstimado = tiempo;
			
		}
		
		//Propiedades
		public string NOMBREPROPIETARIO{
			
			get { return this.NombrePropietario; }
			set { this.NombrePropietario = value; }
			
		}
		
		public string APELLIDOPROPIETARIO{
			
			get { return this.ApellidoPropietario; }
			set { this.ApellidoPropietario = value; }
			
		}
		
		public int DNIPROPIETARIO{
			
			get { return this.DniPropietario; }
			set { this.DniPropietario = value; }
			
		}
		
		public int CODIGO{
			
			get { return this.Codigo; }
			set { this.Codigo = value; }
			
		}
		
		public string TIPO{
			
			get { return this.Tipo; }
			set { this.Tipo = value; }
			
		}
		
		public string TIEMPOESTIMADO{
			
			get { return this.TiempoEstimado; }
			set { this.TiempoEstimado = value; }
			
		}
		
		public int GRUPOASIGNADO{
			
			get { return this.GrupoAsignado; }
			set { this.GrupoAsignado = value; }
			
		}
		
		public string AVANCE{
			
			get { return this.Avance; }
			set { this.Avance = value; }
			
		}
		
		public float COSTO{
			
			get { return this.Costo; }
			set { this.Costo = value; }
			
		}
		
		
		//Metodos
		
			public void ImprimirNombrePropietario()
			{
			    Console.WriteLine("Nombre Propietario: {0}", NombrePropietario);
			}
			
			public void ModificarNombrePropietario(string nuevoNombre)
			{
			    this.NombrePropietario = nuevoNombre;
			}
			
			public void ImprimirApellidoPropietario()
			{
			    Console.WriteLine("Apellido Propietario: {0}", ApellidoPropietario);
			}
			
			public void ModificarApellidoPropietario(string nuevoApellido)
			{
			    this.ApellidoPropietario = nuevoApellido;
			}
			
			public void ImprimirDniPropietario()
			{
			    Console.WriteLine("DNI Propietario: {0}", DniPropietario);
			}
			
			public void ModificarDniPropietario(int nuevoDni)
			{
			    this.DniPropietario = nuevoDni;
			}
			
			public void ImprimirCodigo()
			{
			    Console.WriteLine("Código: {0}", Codigo);
			}
			
			public void ModificarCodigo(int nuevoCodigo)
			{
			    this.Codigo = nuevoCodigo;
			}
			
			public void ImprimirTipo()
			{
			    Console.WriteLine("Tipo: {0}", Tipo);
			}
			
			public void ModificarTipo(string nuevoTipo)
			{
			    this.Tipo = nuevoTipo;
			}
			
			public void ImprimirTiempoEstimado()
			{
			    Console.WriteLine("Tiempo Estimado: {0}", TiempoEstimado);
			}
			
			public void ModificarTiempoEstimado(string nuevoTiempo)
			{
			    this.TiempoEstimado = nuevoTiempo;
			}
			
			public void ImprimirGrupoAsignado()
			{
			    Console.WriteLine("Grupo Asignado: {0}", GrupoAsignado);
			}
			
			public void ModificarGrupoAsignado(int nuevoGrupo)
			{
			    this.GrupoAsignado = nuevoGrupo;
			}
			
			public void ImprimirAvance()
			{
			    Console.WriteLine("Avance: {0}", Avance);
			}
			
			public void ModificarAvance(string nuevoAvance)
			{
			    this.Avance = nuevoAvance;
			}
			
			public void ImprimirCosto()
			{
			    Console.WriteLine("Costo: {0}", Costo);
			}
			
			public void ModificarCosto(float nuevoCosto)
			{
			    this.Costo = nuevoCosto;
			}

		
	}
}
