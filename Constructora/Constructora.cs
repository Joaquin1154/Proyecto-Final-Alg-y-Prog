/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/5/2023
 * Hora: 14:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Constructora
{
	/// <summary>
	/// Clase Constructora
	/// </summary>
	public class Constructora
	{
		//Atributos de la clase
		private int CodigoObra;
		private int Legajos;
		private ArrayList Obreros;
		private ArrayList GruposObreros;
		private ArrayList Obras;
		private ArrayList ObrasFinalizadas;
		
		//Constructores
		public Constructora(){
			
			this.CodigoObra = 0;
			this.Legajos = 0;
			this.Obreros = new ArrayList();
			this.GruposObreros = new ArrayList();
			this.Obras = new ArrayList();
			this.ObrasFinalizadas = new ArrayList();
			
		}
		
		//Propiedades
		public int CODIGOOBRA{
			
			get { return this.CodigoObra; }
			set { this.CodigoObra = value; }
			
		}
		
		public int LEGAJOS{
			
			get { return this.Legajos; }
			set { this.Legajos = value; }
			
		}
		
		public ArrayList OBREROS{
			
			get { return this.Obreros; }
			set { this.Obreros = value; }
			
		}
		
		public ArrayList GRUPOSOBREROS{
			
			get { return this.GruposObreros; }
			set { this.GruposObreros = value; }
			
		}
		
		public ArrayList OBRAS{
			
			get { return this.Obras; }
			set { this.Obras = value; }
			
		}
		
		public ArrayList OBRASFINALIZADAS{
			
			get { return this.ObrasFinalizadas; }
			set { this.ObrasFinalizadas = value; }
			
		}
		
		//Métodos
		public void AgregarObrero(Obrero obrero){
			
			this.Obreros.Add(obrero);
			
		}
		
		public void AgregarObreroAGrupo(Obrero obrero){ //Este método recibe una instacia de Obrero y agrega el legajo del Obrero
														// a la lista de obreros del grupo de obreros correspondiente.
			
			foreach(GrupoObreros grupo in GruposObreros){
				
				if(grupo.NUMEROGRUPO == obrero.GRUPO){
					
					grupo.AgregarObrero(obrero.LEGAJO);
					
				}
				
			}
			
		}
		
		public void AgregarObra(Obra obra){
			
			this.Obras.Add(obra);
			
		}
		
		public void AgregarGrupo(GrupoObreros grupo){
			
			this.GruposObreros.Add(grupo);
			
		}
		
		public bool EliminarObrero(int dni){ //Metodo para eliminar un obrero
			bool eliminado = false;
			for (int i = 0; i < Obreros.Count; i++){
				
				Obrero obr = (Obreros[i]) as Obrero;
				
				if(obr.DNI == dni){
					
					Obreros.RemoveAt(i);
					eliminado = true;
					break;
				}
				
			}
			return eliminado;
			
		}
		
		public bool EliminarObra(int codigo){
			bool eliminada = false;
			
			for (int i = 0; i < Obras.Count; i++){
				
				Obra obra = Obras[i] as Obra;
				
				if (obra.CODIGO == codigo){
					
					Obras.RemoveAt(i);
					eliminada = true;
					break;
					
				}
				
			}
			
			return eliminada;
			
		}
		
		public void AgregarObraFinalizada(Obra obra){
			
			
			this.ObrasFinalizadas.Add(obra);
			
			
		}
		
		public void ImprimirObreros(){
			
			foreach(Obrero obrero in Obreros){
				
				
				Console.WriteLine("* Nombre y Apellido: {0} {1}   Dni: {2}    Legajo: {3}", obrero.NOMBRE, obrero.APELLIDO, obrero.DNI, obrero.LEGAJO);
				Console.WriteLine("Cargo: {0}    Grupo asignado: {1}", obrero.CARGO, obrero.GRUPO);
				Console.WriteLine("---------------------------------------------------------------------------------------");
			}
			
			
		}
		
		 public void ImprimirObras(){
			
        foreach (Obra obra in Obras)
        {
            Console.WriteLine("* Nombre Propietario: {0} {1}   DNI Propietario: {2}    Código: {3}", obra.NOMBREPROPIETARIO, obra.APELLIDOPROPIETARIO, obra.DNIPROPIETARIO, obra.CODIGO);
            Console.WriteLine("Tipo: {0}    Tiempo Estimado: {1}", obra.TIPO, obra.TIEMPOESTIMADO);
            Console.WriteLine("Grupo Asignado: {0}    Avance: {1}    Costo: {2}", obra.GRUPOASIGNADO, obra.AVANCE, obra.COSTO);
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
		
		public void ImprimirObrasFinalizadas(){
			
        foreach (Obra obra in Obras)
        {
            Console.WriteLine("* Nombre Propietario: {0} {1}   DNI Propietario: {2}    Código: {3}", obra.NOMBREPROPIETARIO, obra.APELLIDOPROPIETARIO, obra.DNIPROPIETARIO, obra.CODIGO);
            Console.WriteLine("Tipo: {0}    Tiempo Estimado: {1}", obra.TIPO, obra.TIEMPOESTIMADO);
            Console.WriteLine("Grupo Que Tenía Asignado: {0}    Costo: {1}", obra.GRUPOASIGNADO, obra.COSTO);
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
		
		public void ImprimirGruposObreros(){
			
			
        foreach (GrupoObreros grupoObreros in GruposObreros){
				
				
		            Console.WriteLine("Número de Grupo: {0}    Código de la Obra Asignada:{1}", grupoObreros.NUMEROGRUPO, grupoObreros.CODIGOOBRA);
		            Console.WriteLine("Legajos de Los Obreros del Grupo:");
		            foreach (int legajo in grupoObreros.OBREROS)
		            {
		                Console.WriteLine("- Legajo: {0}", legajo);
		            }
		            Console.WriteLine("---------------------------------------------------------------------------------------");
		        }
   		 }
		
		public void ImprimirCodigosObra(){
			Console.WriteLine("Estos son los codigos de obra usados hasta el momento: {0}", CodigoObra);
			
		}
		
		public void ImprimirLegajos(){
			
			Console.WriteLine("Estos son los legajos usados hasta el momento: {0}", Legajos);
			
		}
		
		public void ModificarLegajo(int legajosnuevos){
			
			this.Legajos = legajosnuevos;
			
		}
		
		public void ModificarCodigosObras(int codigosnuevos){
			
			this.CodigoObra = codigosnuevos;
			
		}
		
	}
}
