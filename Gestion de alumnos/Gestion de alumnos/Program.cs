using System;
using System.IO;

namespace Gestion_de_alumnos
{
    internal class Program
    {
        static int cantidad = 0;
        static int capacidad = 20;
        static Alumno[] alumnos = new Alumno[capacidad];
        static void Main(string[] args)
        {
            DatosPrueba();
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            string opcion;
            do
            {
                Console.WriteLine("Bienvenidos al portal estudiantil. Elija una de las siguientes opciones:");
                Console.WriteLine("1. Añadir un alumno");
                Console.WriteLine("2. Mostrar todos los alumnos");
                Console.WriteLine("3. Actualizar alumno");
                Console.WriteLine("4. Eliminar alumno");
                Console.WriteLine("5. Buscar alumno");
                Console.WriteLine("6. Nota media alumnos");
                Console.WriteLine("7. Salir");
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        AnyadirAlumno();
                        break;
                    case "2":
                        MostrarAlumnos();
                        break;
                    case "3":
                        ActualizarAlumno();
                        break;
                    case "4":
                        EliminarAlumno();
                        break;
                    case "5":
                        BuscarAlumno();
                        break;
                    case "6":
                        NotaMedia();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Error, debe elegir entre las opciones 1 y 7");
                        break;
                }
            } while (opcion != "7");
        }

        public static void DatosPrueba()
        {
            cantidad = 3;
            alumnos[0] = new Alumno("Pepe", "Garcia", "17", 5.5f);
            alumnos[1] = new Alumno("Maria", "Perez", "16", 6.4f);
            alumnos[2] = new Alumno("Julia", "Martinez", "18", 7.7f);
        }
        public static void AnyadirAlumno()
        {
            string nombre;
            string apellido;
            string edad;
            float nota;
            do
            {
                Console.Write("Nombre del alumno: ");
                nombre = Console.ReadLine();
                
                if(nombre == "") 
                {
                    Console.WriteLine("ERROR. Este campo es obligatorio de rellenar. Pulse enter para continuar..");
                    Console.ReadLine();
                }

            } while (nombre == "");


            do
            {
                Console.Write("Apellido del alumno: ");
                apellido = Console.ReadLine();

                if (apellido == "")
                {
                    Console.WriteLine("ERROR. Este campo es obligatorio de rellenar. Pulse enter para continuar..");
                    Console.ReadLine();
                }
            } while (apellido == "");


            do
            {
                Console.Write("Edad del alumno: ");
                edad = Console.ReadLine();

                if (edad == "")
                {
                    Console.WriteLine("ERROR. Este campo es obligatorio de rellenar. Pulse enter para continuar..");
                    Console.ReadLine();
                }
            } while (edad == "");


            do
            {
                Console.Write("Nota del alumno: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota <= -1)
                {
                    Console.WriteLine("ERROR. Este campo es obligatorio de rellenar. Pulse enter para continuar..");
                    Console.ReadLine();
                }
            } while (nota < -1);


            if (cantidad < capacidad)
            {
                alumnos[cantidad] =new Alumno(nombre, apellido, edad, nota);
                cantidad++;
            }
            Console.WriteLine("Alumno guardado correctamente. Pulse enter para continuar..");
            Console.ReadLine();
            Console.Clear();
        }
        public static void MostrarAlumnos()
        {
            Console.WriteLine("Estos son los alumnos guardados:");

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine((i + 1) + ". " + alumnos[i].ToString());
            }
            Console.WriteLine("Pulse enter para continuar..");
            Console.ReadLine();
            Console.Clear();
        }
        public static void EliminarAlumno()
        {
            int posicionBorrar = -1;

            do
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine((i + 1) + ". " + alumnos[i].ToString());
                }
                Console.WriteLine("¿Qué alumno quiere borrar?: ");

                try
                {
                    posicionBorrar = Convert.ToInt32(Console.ReadLine());

                    if (posicionBorrar > cantidad || posicionBorrar <= 0)
                    {
                        Console.WriteLine("Error, debe seleccionar uno de los alumnos mostrados.");
                    }
                    else
                    {
                        for (int i = posicionBorrar; i < cantidad -1; i++)
                        {
                            alumnos[i] = alumnos[i + 1];
                        }
                        cantidad--;
                        Console.WriteLine("Alumno eliminado correctamente. Pulse enter para continuar..");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception e) 
                { 
                    Console.WriteLine("Error, peto el programa");
                    Console.ReadLine();
                }
                Console.Clear();

            } while (posicionBorrar > cantidad || posicionBorrar <= 0);
        }
        public static void BuscarAlumno()
        {
            string nombreAlumno;
            bool encontrado = false;

            Console.Write("Introduce el nombre del alumno que desea buscar: ");
            nombreAlumno = Console.ReadLine();

           for(int i = 0; i < cantidad; i++) 
            {
                if (alumnos[i].Nombre.Contains(nombreAlumno)) 
                {
                    Console.WriteLine("El alumno introducido está guardado. Pulse enter para continuar..");
                    encontrado = true;
                    break;
                }
                else
                {
                    encontrado = false; //falla por aqui
                    Console.WriteLine("El alumno introducido no está guardado. Pulse enter para continuar..");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        public static void ActualizarAlumno()
        {
            int posicionEditar = -1;
            string nuevoNombre = "";
            string nuevoApellido = "";
            string nuevaEdad = "";

            do
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine((i + 1) + ". " + alumnos[i].ToString());
                }
                Console.WriteLine("¿Qué alumno quiere editar?: ");

                try
                {
                    posicionEditar = Convert.ToInt32(Console.ReadLine());

                    if (posicionEditar > cantidad || posicionEditar <= 0)
                    {
                        Console.WriteLine("Error, debe seleccionar uno de los alumnos mostrados.");
                    }
                    else
                    {
                        //for(int i = 0;i < cantidad; i++) //esta mal
                        /*
                        Console.WriteLine("El nombre actual del alumno: " + alumnos[i].Nombre);
                        Console.Write("Nuevo nombre: ");
                        nuevoNombre = Console.ReadLine();

                        Console.WriteLine("El nombre actual del alumno: " + alumnos[i].Apellidos);
                        Console.Write("Nuevo nombre: ");
                        nuevoApellido = Console.ReadLine();

                        Console.WriteLine("El nombre actual del alumno: " + alumnos[i].Edad);
                        Console.Write("Nuevo nombre: ");
                        nuevaEdad = Console.ReadLine();*/

                    }
                    Console.WriteLine("Alumno modificado correctamente");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, peto el programa");
                    Console.ReadLine();
                }
                Console.Clear();

            } while (posicionEditar > cantidad || posicionEditar <= 0);
        }
        public static void GuardarDatos()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = new StreamWriter("C:\\Users\\la_so\\OneDrive\\Escritorio\\Ejercicios C#\\Gestion de alumnos\\Gestion de alumnos\\alumnos.txt"))
                //Write a line of text
                foreach(Alumno texto in alumnos)
                {
                    Console.WriteLine(texto.Nombre + texto.Apellidos + texto.Edad);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static void CargarDatos() 
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                using (StreamReader sr = new StreamReader("C:\\Users\\la_so\\OneDrive\\Escritorio\\Ejercicios C#\\Gestion de alumnos\\Gestion de alumnos\\alumnos.txt"));
                //Read the first line of text
                line = Console.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = Console.ReadLine();
                }
                //close the file
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static void NotaMedia()
        {
            float suma = 0;
            float media;

            for(int i = 0; i < cantidad; i++)
            {
                suma = suma + alumnos[i].Nota;
                
            }
            Console.WriteLine("La suma de todas las notas es: " + suma);
            
            media = suma / 2;

            Console.WriteLine("La nota media de los alumnos es: " + media);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
