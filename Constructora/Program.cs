/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 20/5/2023
 * Hora: 19:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Constructora
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Constructora empresa = new Constructora(); //Creación de la empresa.
			
			
//------------CREACION Y CARGA DE OBJETOS INTERVINIENTES PARA DAR RESPUESTA A LAS OPCIONES DEL MENU---------------
			

//Creación Y carga de los 8 grupos de obreros
			
			GrupoObreros grupo1 = new GrupoObreros();
			grupo1.NUMEROGRUPO = 1;
			empresa.AgregarGrupo(grupo1);
			
			GrupoObreros grupo2 = new GrupoObreros();
			grupo2.NUMEROGRUPO = 2;
			empresa.AgregarGrupo(grupo2);
			
			GrupoObreros grupo3 = new GrupoObreros();
			grupo3.NUMEROGRUPO = 3;
			empresa.AgregarGrupo(grupo3);
			
			GrupoObreros grupo4 = new GrupoObreros();
			grupo4.NUMEROGRUPO = 4;
			empresa.AgregarGrupo(grupo4);
			
			GrupoObreros grupo5 = new GrupoObreros();
			grupo5.NUMEROGRUPO = 5;
			empresa.AgregarGrupo(grupo5);
			
			GrupoObreros grupo6 = new GrupoObreros();
			grupo6.NUMEROGRUPO = 6;
			empresa.AgregarGrupo(grupo6);
			
			GrupoObreros grupo7 = new GrupoObreros();
			grupo7.NUMEROGRUPO = 7;
			empresa.AgregarGrupo(grupo7);
			
			GrupoObreros grupo8 = new GrupoObreros();
			grupo8.NUMEROGRUPO = 8;
			empresa.AgregarGrupo(grupo8);
			
//Creacion de dos obreros para cada grupo (16 en total)
			int legajo1 = AsignarLegajo(ref empresa);
			Obrero obrero1 = new Obrero("Juan", "Gomez", 12345678, legajo1, "Capataz", 1);
			
			int legajo2 = AsignarLegajo(ref empresa);
			Obrero obrero2 = new Obrero("Pedro", "Lopez", 23456789, legajo2, "Albañil", 1);
			
			int legajo3 = AsignarLegajo(ref empresa);
			Obrero obrero3 = new Obrero("Carlos", "Fernández", 34567890, legajo3, "Plomero", 2);
			
			int legajo4 = AsignarLegajo(ref empresa);
			Obrero obrero4 = new Obrero("Ana", "Pérez", 45678901, legajo4, "Electricista", 2);
			
			int legajo5 = AsignarLegajo(ref empresa);
			Obrero obrero5 = new Obrero("Laura", "Hernández", 56789012, legajo5, "Gasista", 3);
			
			int legajo6 = AsignarLegajo(ref empresa);
			Obrero obrero6 = new Obrero("Martín", "Sánchez", 67890123, legajo6, "Capataz", 3);
			
			int legajo7 = AsignarLegajo(ref empresa);
			Obrero obrero7 = new Obrero("Diego", "Flores", 78901234, legajo7, "Peón", 4);
			
			int legajo8 = AsignarLegajo(ref empresa);
			Obrero obrero8 = new Obrero("Carolina", "Mendoza", 89012345, legajo8, "Plomero", 4);
			
			int legajo9 = AsignarLegajo(ref empresa);
			Obrero obrero9 = new Obrero("Fernanda", "Gutiérrez", 90123456, legajo9, "Pintor", 5);
			
			int legajo10 = AsignarLegajo(ref empresa);
			Obrero obrero10 = new Obrero("Roberto", "Luna", 12345098, legajo10, "Gasista", 5);
			
			int legajo11 = AsignarLegajo(ref empresa);
			Obrero obrero11 = new Obrero("Gabriela", "Navarro", 23456109, legajo11, "Capataz", 6);
			
			int legajo12 = AsignarLegajo(ref empresa);
			Obrero obrero12 = new Obrero("Andrés", "Silva", 34567210, legajo12, "Albañil", 6);
			
			int legajo13 = AsignarLegajo(ref empresa);
			Obrero obrero13 = new Obrero("Eduardo", "García", 45678321, legajo13, "Electricista", 7);
			
			int legajo14 = AsignarLegajo(ref empresa);
			Obrero obrero14 = new Obrero("Lucía", "Cruz", 56789432, legajo14, "Pintor", 7);
			
			int legajo15 = AsignarLegajo(ref empresa);
			Obrero obrero15 = new Obrero("Lorena", "Morales", 67890543, legajo15, "Gasista", 8);
			
			int legajo16 = AsignarLegajo(ref empresa);
			Obrero obrero16 = new Obrero("Sebastián", "López", 78901654, legajo16, "Capataz", 8);
			
//Se agrega cada obrero a la empresa y al grupo correspondiente

			empresa.AgregarObrero(obrero1);
			empresa.AgregarObreroAGrupo(obrero1);
			empresa.AgregarObrero(obrero2);
			empresa.AgregarObreroAGrupo(obrero2);
			empresa.AgregarObrero(obrero3);
			empresa.AgregarObreroAGrupo(obrero3);
			empresa.AgregarObrero(obrero4);
			empresa.AgregarObreroAGrupo(obrero4);
			empresa.AgregarObrero(obrero5);
			empresa.AgregarObreroAGrupo(obrero5);
			empresa.AgregarObrero(obrero6);
			empresa.AgregarObreroAGrupo(obrero6);
			empresa.AgregarObrero(obrero7);
			empresa.AgregarObreroAGrupo(obrero7);
			empresa.AgregarObrero(obrero8);
			empresa.AgregarObreroAGrupo(obrero8);
			empresa.AgregarObrero(obrero9);
			empresa.AgregarObreroAGrupo(obrero9);
			empresa.AgregarObrero(obrero10);
			empresa.AgregarObreroAGrupo(obrero10);
			empresa.AgregarObrero(obrero11);
			empresa.AgregarObreroAGrupo(obrero11);
			empresa.AgregarObrero(obrero12);
			empresa.AgregarObreroAGrupo(obrero12);
			empresa.AgregarObrero(obrero13);
			empresa.AgregarObreroAGrupo(obrero13);
			empresa.AgregarObrero(obrero14);
			empresa.AgregarObreroAGrupo(obrero14);
			empresa.AgregarObrero(obrero15);
			empresa.AgregarObreroAGrupo(obrero15);
			empresa.AgregarObrero(obrero16);
			empresa.AgregarObreroAGrupo(obrero16);
			

//Creación y carga de obras:
			int codigo1 = AsignarCodigoObra(ref empresa);
			Obra obra1 = new Obra("Juan", "Gómez", 12345678, codigo1, "Construcción", 2, "30%", 50000, "45 dias");
			empresa.AgregarObra(obra1); //Se agrega la obra a la lista de obras de la empresa		
			AsignarObraGrupo(ref empresa, obra1.CODIGO, obra1.GRUPOASIGNADO); //Se llama a la funcion para ocupar el grupo asignado
			
			int codigo2 = AsignarCodigoObra(ref empresa);
			Obra obra2 = new Obra("María", "López", 23456789, codigo2, "Remodelación", 4, "60%", 80000, "120 dias");
			empresa.AgregarObra(obra2); //Se agrega la obra a la lista de obras de la empresa
			AsignarObraGrupo(ref empresa, obra2.CODIGO, obra2.GRUPOASIGNADO); //Se llama a la funcion para ocupar el grupo asignado
			
			int codigo3 = AsignarCodigoObra(ref empresa);
			Obra obra3 = new Obra("José", "López", 563489257, codigo3, "Construccion", 5, "40%", 85000, "180 dias");
			empresa.AgregarObra(obra3); //Se agrega la obra a la lista de obras de la empresa
			AsignarObraGrupo(ref empresa, obra3.CODIGO, obra3.GRUPOASIGNADO); //Se llama a la funcion para ocupar el grupo asignado
			
			int codigo4 = AsignarCodigoObra(ref empresa);
			Obra obra4 = new Obra("Pablo", "Sanchez", 95821764, codigo4, "pintura", 6, "50%", 65000, "100 dias");
			empresa.AgregarObra(obra4); //Se agrega la obra a la lista de obras de la empresa
			AsignarObraGrupo(ref empresa, obra4.CODIGO, obra4.GRUPOASIGNADO); //Se llama a la funcion para ocupar el grupo asignado
			
			
			int codigo5 = AsignarCodigoObra(ref empresa);
			Obra obra5 = new Obra("Roberto", "Insaurralde", 34509867, codigo5, "Remodelación", 7, "30%", 125000, "150 dias");
			empresa.AgregarObra(obra5); //Se agrega la obra a la lista de obras de la empresa
			AsignarObraGrupo(ref empresa, obra5.CODIGO, obra5.GRUPOASIGNADO); //Se llama a la funcion para ocupar el grupo asignado
			
			
			int codigo6 = AsignarCodigoObra(ref empresa);
			Obra obra6 = new Obra("Raúl", "Vázques", 78213409, codigo6, "Demolición", 1, "70%", 145000, "160 dias");
			empresa.AgregarObra(obra6); //Se agrega la obra a la lista de obras de la empresa
			AsignarObraGrupo(ref empresa, obra6.CODIGO, obra6.GRUPOASIGNADO); //Se llama a la funcion para ocupar el grupo asignado
			
			int codigo7 = AsignarCodigoObra(ref empresa);
			Obra obra7 = new Obra("Martín", "Luzuriaga", 593874512, codigo7, "Ampliación", 7, "20%", 40000, "90 dias");
			//Esta obra se guarda directamente en la lista de obras finalizadas.
			empresa.AgregarObraFinalizada(obra7);
			
			int codigo8 = AsignarCodigoObra(ref empresa);
			Obra obra8 = new Obra("Pedro", "Martínez", 34567890, codigo8, "Ampliación", 6, "100%", 96000, "45 dias");
			//Esta obra se guarda directamente en la lista de obras finalizadas.
			empresa.AgregarObraFinalizada(obra8);

			
			int opcion = 0;
			
			Console.WriteLine("--------------------Bienvenido----------------------");
			
			do{
				
				Console.WriteLine();
				Console.WriteLine("1- Contratar un obrero nuevo.");
				Console.WriteLine("2- Eliminar un obrero.");
				Console.WriteLine("3- Imprimir listado de obreros.");
				Console.WriteLine("4- Imprimir listado de obras.");
				Console.WriteLine("5- Agregar una obra nueva");
				Console.WriteLine("6- Modificar el estado de avance de una obra.");
				Console.WriteLine("7- Imprimir listado de obras finalizadas.");
				Console.WriteLine("8- Salir.");
				
				Console.Write("Seleccione una opción del menú: ");
				opcion = int.Parse(Console.ReadLine());
				
				switch (opcion){
						
					case 1:
						
						AgregarObreroEmpGrup(ref empresa);
						break;
						
					case 2:
						
						EliminarObreroEmpGrup(ref empresa);
						break;
						
					case 3:
						
						ImprimirObreros(empresa);
						break;
						
					case 4:
						
						ListadoObras(empresa);
						break;
						
					case 5:
						
						AgregarObraEmpresa(ref empresa);
						break;
						
					case 6:
						
						ModificarAvanceObra(ref empresa);
						break;
						
					case 7:
						
						ListadoObrasFinalizadas(empresa);
						break;
						
					case 8:
						
						Console.WriteLine("Saliendo...");
						break;
						
					default:
						
						Console.WriteLine("Opción inválida. Por favor, ingrese una opción del menú");
						break;
						
				}
				
			} while (opcion != 8);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//Funciones
		
		public static void AgregarObreroEmpGrup(ref Constructora empresa){ //Funcion para crear y agregar un obrero a la empresa y a un grupo
			
			int continuar = 1;
			
			while (continuar == 1){
				
				Console.WriteLine("Para agregar un obrero, primero ingrese los datos del obrero.");
				Console.Write("Nombre: ");
				string nom = Console.ReadLine();
				Console.Write("Apellido: ");
				string ape = Console.ReadLine();
				Console.Write("Dni: ");
				int dni = int.Parse(Console.ReadLine());
				int legajo = AsignarLegajo(ref empresa);
				Console.Write("Cargo: ");
				string cargo = Console.ReadLine();
				Console.Write("Número del grupo al que desea agregar al obrero: ");
				int grupo = int.Parse(Console.ReadLine());
				
				Obrero obrero = new Obrero(nom, ape, dni, legajo, cargo, grupo); //Se crea el obrero
				
				empresa.AgregarObrero(obrero); //Se agrega el obrero a la empresa
				 	
				foreach (GrupoObreros objeto in empresa.GRUPOSOBREROS){ //Se busca el grupo para agregar al obrero
					
					if(objeto.NUMEROGRUPO == grupo){
						
						objeto.AgregarObrero(obrero.LEGAJO);
						break;
						
					}
					
				}
				
				Console.WriteLine("El obrero {0} {1} se agregó al grupo {2} correctamente", obrero.NOMBRE, obrero.APELLIDO, grupo);
				Console.Write("Ingrese 1 para agregar otro obrero o 0 para volver al menú principal: ");
				continuar = int.Parse(Console.ReadLine());
				
			}
			
		}
		
		public static void ModificarAvanceObra(ref Constructora empresa){ //Funcion para modificar el avance de una obra
			
			int continuar = 1;
		
			while (continuar == 1){
				
				Console.Write("Para modificar el estado de avance de una obra, primero ingrese el Dni del propietario de la obra: ");
				int DniPropietario = int.Parse(Console.ReadLine());
				
				foreach (Obra obra in empresa.OBRAS){ //Se busca la obra con el Dni ingresado
					
					if (obra.DNIPROPIETARIO == DniPropietario){ //Una vez encontrado, se modifica el avance
						
						Console.WriteLine("La obra pertenece a {0} {1} y su estado de avance actual es: {2}", obra.NOMBREPROPIETARIO, obra.APELLIDOPROPIETARIO, obra.AVANCE);
						Console.Write("Ingrese el avance actual en el mismo formato (xx%) para modificarlo: ");
						obra.AVANCE = Console.ReadLine();
						Console.WriteLine("El avance de la obra se a modificado, ahora es {0}", obra.AVANCE);
						
						if (obra.AVANCE == "100%"){ //Si el nuevo avance es 100% se procede a mover la obra a la lista de
													//finalizadas y a liberar el grupo que tenia asignado la obra.
							
							MoverObra(ref empresa, obra);
							LiberarGrupo(ref empresa, obra.GRUPOASIGNADO);
							
							Console.WriteLine("Como el nuevo avance es 100% se movió la obra a la lista de finalizadas y se liberó el grupo {0}", obra.GRUPOASIGNADO);
							
						}
						
						break;
						
					}
					
				}
				
				Console.Write("Ingrese 1 para modificar el avance de otra obra o 0 para volver al menú principal: ");
				continuar = int.Parse(Console.ReadLine());
				
			}
			
		}
		
		public static void AgregarObraEmpresa(ref Constructora empresa){ //Funcion para agregar una obra y asignarle un grupo
			
			int continuar = 1;
			
			while (continuar == 1){
				
				int Grupo = 0;
				bool GrupoAsignado = true;
				try{
					
					Grupo = GrupoLibre(empresa);  //Se verifica si hay un grupo libre y se guarda el N° de grupo.
				}
				
				catch(SinGrupoLibreException){
					
					Console.WriteLine("No hay ningun grupo disponible para asignar a la obra, primero debe finalizar una obra.");
					GrupoAsignado = false;  //En caso de que no lo haya, se larga la excepción y se cambia GrupoAsignado
											//por false para que no se ejecute el bloque if.
				}
				
				if (GrupoAsignado){
					
					Console.WriteLine("Para agregar una obra, primero, ingrese los datos correspondientes: ");
					Console.Write("Nombre del propietario: ");
					string nombre = Console.ReadLine();
					Console.Write("Apellido del propietario: ");
					string apellido = Console.ReadLine();
					Console.Write("Dni del propietario: ");
					int dni = int.Parse(Console.ReadLine());
					Console.Write("Tipo de obra: ");
					string tipo = Console.ReadLine();
					Console.Write("Ingrese el tiempo estimado expresado en (numero) (dias): ");
					string TiempoEstimado = Console.ReadLine();
					Console.Write("Costo de la obra (en pesos argentinos): ");
					float costo = float.Parse(Console.ReadLine());
					int codigo = AsignarCodigoObra(ref empresa);
					string avance = "0%";
					
					Obra obra = new Obra(nombre, apellido, dni, codigo, tipo, Grupo, avance, costo, TiempoEstimado); //Se crea la obra y se le asigna el grupo libre
					
					empresa.AgregarObra(obra); //Se agrega la obra a la lista de obras de la empresa
					
					AsignarObraGrupo(ref empresa, codigo, Grupo); //Se llama a la funcion para ocupar el grupo asignado
					
					Console.WriteLine("Se creó la obra de {0} {1}, se le asignó el grupo {2} y el código interno {3}.", nombre, apellido, Grupo, codigo);
				
				}
				
				if (GrupoAsignado){ //Se ejecuta en caso de crear la obra
					
					Console.Write("Ingrese 1 para agregar otra obra o 0 para volver al menú principal: ");
					continuar = int.Parse(Console.ReadLine());
					
				}
				
				else{
					
				Console.Write("Ingrese 0 para volver al menú principal: ");
				continuar = int.Parse(Console.ReadLine());
				
				}
				
			}
			
		}
		
		public static void EliminarObreroEmpGrup(ref Constructora empresa){ //Funcion para eliminar un obrero de la epresa y de su grupo.
			
			int continuar = 1;
			
			while (continuar == 1){
				
				Console.Write("Para eliminar un obrero de su grupo y de la empresa, ingrese el dni del obrero: ");
				int dni = int.Parse(Console.ReadLine());
				string nombre = null;
				string apellido = null;
				int legajo = 0;
				int grupo = 0;
				
				foreach (Obrero obrero in empresa.OBREROS){ 	//Se recorre la lista de obreos de la empresa
					   											//Se busca el obrero que tenga el dni ingresado
																// y se guarda su nombre y apellido para ser mostrado, y el grupo y legajo para ser eliminado del grupo.
						if (obrero.DNI == dni){
							nombre = obrero.NOMBRE;
							apellido = obrero.APELLIDO;
							legajo = obrero.LEGAJO;
							grupo = obrero.GRUPO;
							break;
							
						}
						
					
				}
				
				foreach (GrupoObreros grupoobre in empresa.GRUPOSOBREROS){ //Se recorre la lista de obreros para buscar el grupo al que pertenece el obrero
																		// y eliminar el legajo del obrero en la lista de obreros del grupo.
					
					if (grupoobre.NUMEROGRUPO == grupo){

						if (grupoobre.EliminarObrero(legajo)){ //se elimina el legajo de la lista de obrero del Grupo de Obreros.
							
							empresa.EliminarObrero(dni); //Se elimina el obrero de la lista de obreros de la empresa.
																			
							Console.WriteLine("El obrero {0} {1} se eliminó del grupo {2} y de la empresa correctamente.", nombre, apellido, grupo);
							break;
						}
																			
					}
					
				}
				
				
				
				Console.Write("Ingrese 1 para eliminar otro obrero o 0 para volver al menú principal: ");
				continuar = int.Parse(Console.ReadLine());
			}
			
			
		}
		
		public static void ImprimirObreros(Constructora empresa){ //Funcion para imprimir el listado de obreros.
			
			Console.WriteLine("Listado de obreros:");
			Console.WriteLine();
				
			int contador = 1;
			
    			foreach (Obrero obrero in empresa.OBREROS){
				
				Console.WriteLine(contador + "- {0} {1}    Dni: {2}   Legajo: {3}   Cargo: {4}   Grupo: {5}", obrero.NOMBRE, obrero.APELLIDO, obrero.DNI, obrero.LEGAJO, obrero.CARGO, obrero.GRUPO);
				Console.WriteLine("--------------------------------------------------------------------");
				contador = contador + 1;
				
			    	}
			
		}
		
		public static void ListadoObras(Constructora empresa){
			
			int continuar = 1;
			
			while(continuar == 1 ){
				
			Console.WriteLine("Esta es la lista de obras sin terminar: ");
			Console.WriteLine();
			
			foreach (Obra obra in empresa.OBRAS){
				
				Console.WriteLine("Nombre y apellido del propietario: {0} {1}", obra.NOMBREPROPIETARIO, obra.APELLIDOPROPIETARIO);
				Console.WriteLine("Dni del propietario: {0}", obra.DNIPROPIETARIO);
				Console.Write("Tipo de obra: {0}     ", obra.TIPO); 
				Console.Write("Tiempo estimado inicial: {0}     ", obra.TIEMPOESTIMADO);
				Console.WriteLine("Avance: {0}", obra.AVANCE);
				Console.WriteLine("Costo: ${0}", obra.COSTO);
				Console.WriteLine("Grupo asignado: {0}", obra.GRUPOASIGNADO);
				Console.WriteLine("Código: {0}", obra.CODIGO);
				
				Console.WriteLine("------------------------------------------------------------------------------------------");
				
			} 
			
			Console.Write("Ingrese 0 para volver al menú principal: ");
			continuar = int.Parse(Console.ReadLine());
			
			}
		
		}
		
		public static void ListadoObrasFinalizadas(Constructora empresa){
			
			int continuar = 1;
			
			while(continuar == 1){
			Console.WriteLine("Esta es la lista de obras ya finalizadas: ");
			Console.WriteLine();
			
			foreach (Obra obra in empresa.OBRASFINALIZADAS){
				
				Console.WriteLine("Nombre y apellido del propietario: {0} {1}", obra.NOMBREPROPIETARIO, obra.APELLIDOPROPIETARIO);
				Console.WriteLine("Dni del propietario: {0}", obra.DNIPROPIETARIO);
				Console.Write("Tipo de obra: {0}     ", obra.TIPO); 
				Console.Write("Tiempo estimado inicial: {0}     ", obra.TIEMPOESTIMADO);
				Console.WriteLine("Costo: ${0}", obra.COSTO);
				Console.WriteLine("Grupo que tenía asignado: {0}", obra.GRUPOASIGNADO);
				Console.WriteLine("Código: {0}", obra.CODIGO);
				
				Console.WriteLine("------------------------------------------------------------------------------------------");
				
			}
			
			Console.WriteLine("Ingrese 0 para volver al menú principal: ");
			continuar = int.Parse(Console.ReadLine());
			
			}
		
		}
		
		public static int AsignarLegajo(ref Constructora empresa){ //Funcion para asignar un legajo a un obrero
			
			int legajo = empresa.LEGAJOS + 1;
			empresa.LEGAJOS = legajo;
			
			return legajo;
			
		}
		
		public static int AsignarCodigoObra(ref Constructora empresa){ //Función para asignar un codigo a una obra.
			
			int Codigo = empresa.CODIGOOBRA + 1;
			empresa.CODIGOOBRA = Codigo;
			
			return Codigo;
			
		}
		
		public static int GrupoLibre(Constructora empresa){  //Función para buscar un grupo libre que devuelve el número de grupo que está libre
			
			int Grupolibre = 0;
			
			foreach (GrupoObreros objeto in empresa.GRUPOSOBREROS){ //Se recorre la lista de grupos de la empresa
				
				if(objeto.CODIGOOBRA == 0){ //Se busca el grupo que no tenga una obra asignada
					
					Grupolibre = objeto.NUMEROGRUPO; //Una vez encontrado un grupo libre, se guarda el numero de grupo
					break;
					
				}
				
			}
			
			if (Grupolibre > 0){ //Se verifica si se encontró un grupo libre
			
			return Grupolibre; //Se devuelve el numero de grupo libre
			
			}
			
			else{
					throw new SinGrupoLibreException(); //En caso de no encotrarse un grupo libre, se lanza la excepción
				}
			
		}
		
		public static void AsignarObraGrupo(ref Constructora empresa, int CodObra, int NumGrup){ 	//Funcion para ocupar un grupo una vez que
																									//el grupo es asignado a una obra.
			
			foreach (GrupoObreros grupo in empresa.GRUPOSOBREROS){ //Se recorre la lista de grupos de la empresa
				
				if (grupo.NUMEROGRUPO == NumGrup){ //Se comparan los grupos con el numero de grupo que se le asigno a la obra
					
					grupo.CODIGOOBRA = CodObra;		//Una vez encontrado, se ocupa el grupo con el codigo de la obra asignado
					break;
					
				}
				
			}
			
		}
		
		public static void MoverObra(ref Constructora empresa, Obra obra){ //Funcion para mover una obra de la lista de obras
																			// a la lista de obras finalizadas.
			
			empresa.EliminarObra(obra.CODIGO);
			empresa.AgregarObraFinalizada(obra);
			
		}
		
		public static void LiberarGrupo(ref Constructora empresa, int NumGrupo){ //Funcion para desocupar un grupo
			
			foreach (GrupoObreros grupo in empresa.GRUPOSOBREROS){
				
				if (grupo.NUMEROGRUPO == NumGrupo){
					
					grupo.CODIGOOBRA = 0;
					
					break;
					
				}
				
			}
			
		}
		
	}

}