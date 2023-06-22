using System;
using System.Collections.Generic;

namespace Alumnado
{
    class Program
    {
        static List<Alumno>alumnos = new List<Alumno>();
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

                switch (opcion)
                {
                    case "1":
                        AnyadirAlumno();
                        break;
                    case "2":
                        MostrarAlumnos();
                        break;
                    case "3":
                        EditarAlumno();
                        break;
                    case "4":
                        EliminarAlumno();
                        break; 
                    case "5":
                        BuscarAlumno();
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Error, debe elegir entre las opciones 1 y 7");
                        break;
                }
            } while (opcion != "7");
        }

        public static void AnyadirAlumno()
        {
                string nombre;
                string apellido;
                string edad;
                float nota = -1f;

                do
                {
                    Console.Write("Nombre del alumno: ");
                    nombre = Console.ReadLine();

                    if (nombre == "")
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
                    try
                    {
                        nota = float.Parse(Console.ReadLine());

                        if (nota < 0 || nota > 10)
                        {
                            Console.WriteLine("ERROR. Este campo tiene que ser un número entre 0 y 10. Pulse enter para continuar..");
                            Console.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR. Este campo tiene que ser un número entre 0 y 10. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                } while (nota < 0 || nota > 10);

                //alumnos[cantidad] = new Alumno(nombre, apellido, edad, nota);
                alumnos.Add(new Alumno(nombre, apellido, edad, nota));
                
                Console.WriteLine("Alumno guardado correctamente. Pulse enter para continuar..");
                Console.ReadLine();
                Console.Clear();

        }
        public static void DatosPrueba()
        {
            alumnos.Add(new Alumno("Pepe", "Garcia", "17", 6.36f));
            alumnos.Add(new Alumno("Maria", "Fernandes", "18", 7.86f));
            alumnos.Add(new Alumno("Ariel", "Arielaida", "16", 8.36f));
        }

        public static void MostrarAlumnos()
        {
            Console.WriteLine("Estos son los alumnos guardados:");

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.ToString());
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
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno.ToString());
                }
                Console.WriteLine("¿Qué alumno quiere borrar?: ");

                try
                {
                    posicionBorrar = Convert.ToInt32(Console.ReadLine());

                    if (posicionBorrar > alumnos.Count || posicionBorrar <= 0)
                    {
                        Console.WriteLine("Error, debe seleccionar uno de los alumnos mostrados.");
                    }
                    else
                    {
                        alumnos.RemoveAt(posicionBorrar -1);
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

            } while (posicionBorrar > alumnos.Count || posicionBorrar <= 0);
        }

        public static void EditarAlumno()
        {
            int posicionEditar = -1;
            string nuevoNombre = "";
            string nuevosApellidos = "";
            string nuevaEdad = "";

            do
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno.ToString());
                }
                Console.WriteLine("¿Qué alumno quiere editar?: ");

                try
                {
                    posicionEditar = Convert.ToInt32(Console.ReadLine());

                    if (posicionEditar > alumnos.Count || posicionEditar <= 0)
                    {
                        Console.WriteLine("Error, debe seleccionar uno de los alumnos mostrados.");
                    }
                    else
                    {
                        Console.WriteLine("El nombre actual del alumno: " + alumnos[posicionEditar - 1].Nombre);
                        Console.Write("Nuevo nombre: ");
                        nuevoNombre = Console.ReadLine();
                        if (nuevoNombre != "")
                            alumnos[posicionEditar - 1].Nombre = nuevoNombre;

                        Console.WriteLine("Los apellidos actuales del alumno: " + alumnos[posicionEditar - 1].Apellidos);
                        Console.Write("Nuevos apellidos: ");
                        nuevosApellidos = Console.ReadLine();
                        if (nuevosApellidos != "")
                            alumnos[posicionEditar - 1].Apellidos = nuevosApellidos;

                        Console.WriteLine("La edad actual del alumno: " + alumnos[posicionEditar - 1].Edad);
                        Console.Write("Nueva edad: ");
                        nuevaEdad = Console.ReadLine();
                        if (nuevaEdad != "")
                            alumnos[posicionEditar - 1].Edad = nuevaEdad;
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

            } while (posicionEditar > alumnos.Count || posicionEditar <= 0);
        }

        public static void BuscarAlumno()
        {
            string campoNumero;

            do
            {
                Console.WriteLine("Por que campo quieres buscar?");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Apellidos");
                Console.WriteLine("3. Edad");

                campoNumero = Console.ReadLine();
                string campo = "";

                switch (campoNumero)
                {
                    case "1":
                        campo = "Nombre";
                        break;
                    case "2":
                        campo = "Apellidos";
                        break;
                    case "3":
                        campo = "Edad";
                        break;
                }

                if (campoNumero == "1" || campoNumero == "2" || campoNumero == "3")
                {
                    string busqueda;
                    bool encontrado = false;

                    Console.Write("Introduce el " + campo + " del alumno que desea buscar: ");
                    busqueda = Console.ReadLine();

                    foreach (Alumno alumno in alumnos)
                    {
                        int i = 0;
                        if ((campoNumero == "1" && alumno.Nombre.ToLower().Contains(busqueda.ToLower())) ||
                            (campoNumero == "2" && alumno.Apellidos.ToLower().Contains(busqueda.ToLower())) ||
                            (campoNumero == "3" && alumno.Edad == busqueda))
                        {
                            encontrado = true;
                            Console.WriteLine((i + 1) + ". " + alumno.ToString());
                            i++;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No se ha encontrado el alumno. Pulse enter para continuar...");
                    }

                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Error, el campo introducido no es correcto. Introduzca valor del 1 al 3. Pulse enter para continuar..");
                    Console.ReadLine();
                }
            }
            while (campoNumero != "1" && campoNumero != "2" && campoNumero != "3");
        }
    }
}
