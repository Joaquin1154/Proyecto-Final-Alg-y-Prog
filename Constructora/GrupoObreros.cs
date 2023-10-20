/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/5/2023
 * Hora: 14:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Constructora
{
	/// <summary>
	/// Clase GrupoObreros.
	/// </summary>
	public class GrupoObreros
	{
		//Atributos de la clase
		private ArrayList Obreros;
		private int CodigoObra;
		private int NumeroGrupo;
		
		//Constructores
		public GrupoObreros(){
		
			this.Obreros = new ArrayList();
			this.CodigoObra = 0;
			
		}
		
		public GrupoObreros(int codiobra, int numgrupo){
			
			this.Obreros = new ArrayList();
			this.CodigoObra = codiobra;
			this.NumeroGrupo = numgrupo;
			
		}
		
		public GrupoObreros(int codiobra){
			
			this.Obreros = new ArrayList();
			this.CodigoObra = codiobra;
			
		}
		
		//Propiedades
		public int CODIGOOBRA{
			
			get { return this.CodigoObra; }
			set { this.CodigoObra = value; }
			
		}
		
		public int NUMEROGRUPO{
			
			get { return this.NumeroGrupo; }
			set { this.NumeroGrupo = value; }
			
		}
		
		public ArrayList OBREROS{
			
			get { return this.Obreros; }
			set { this.Obreros = value; }
			
		}
		
		//Metodos
		public void AgregarObrero(int legajo){  //Metodo para agregar un obrero
			
			this.Obreros.Add(legajo);
			
		}
		
		public bool EliminarObrero(int legajo){ //Metodo para eliminar un obrero
			bool eliminado = false;
			for (int i = 0; i < Obreros.Count; i++){
				
				if((int)Obreros[i] == legajo){
					
					Obreros.RemoveAt(i);
					eliminado = true;
					break;
				}
				
			}
			return eliminado;
			
		}
		
		public void ImprimirLegajosDeObreros(){
			
			foreach (int legajo in Obreros){
				
				Console.WriteLine("*Legajo: {0} ", legajo);
				
			}
			
		}
		
		public void ImprimirNumeroGrupo(){
			
			Console.WriteLine("Número de Grupo: {0}", NumeroGrupo);
		}
		
		public void ModificarNumeroGrupo(int numeroGrupo)
		{
		    this.NUMEROGRUPO = numeroGrupo;
		}
		
		public void ImprimirCodigoObra(){
			
			Console.WriteLine("Código de obra asignada: {0}", CodigoObra);
			
		}
		
		public void ModificarCodigoObra(int codigoObra)
		{
		    this.CODIGOOBRA = codigoObra;
		}
		
	}
}
