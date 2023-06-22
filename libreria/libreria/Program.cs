using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace libreria
{
    internal class Program
    {
        static int capacidad = 100;
        static int cantidad = 0;
        static Libro[] libros = new Libro[capacidad];
        static void Main(string[] args)
        {
            CargarLibros();
            //IntroducirDatosPrueba();
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            string opcion;
            do
            {
                Console.WriteLine("Bienvenid@. Elige una de las siguientes opciones:");
                Console.WriteLine("1. Añadir un libro");
                Console.WriteLine("2. Mostrar todos los libros");
                Console.WriteLine("3. Editar un libro");
                Console.WriteLine("4. Buscar un libro");
                Console.WriteLine("5. Eliminar un libro");
                Console.WriteLine("6. Mostrar generos libros");
                Console.WriteLine("7. Salir");
       
                opcion= Console.ReadLine();
                Console.Clear();
                
                switch (opcion)
                {
                    case "1":
                        AnyadirLibro();
                        GuardarLibros();
                        break;
                    case "2":
                        MostrarLibro();
                        break;
                    case "3":
                        ModificarLibro();
                        GuardarLibros();
                        break;
                    case "4":
                        BucarLibro();
                        break;
                    case "5":
                        EliminarLibro();
                        GuardarLibros();
                        break;
                    case "6":
                        MostrarGenerosLibros();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Error, debes elegir una opción entre la 1 y la 5.");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != "7");
        }

        public static void AnyadirLibro()
        {
            string nombre = PedirTextoObligatorio("Nombre del libro");
            string genero = PedirTextoObligatorio("Genero del libro");
            string autor = PedirTextoObligatorio("Autor del libro");
            string anyo;
            bool numeroValido;
            do
            {
                Console.Write("Introduce el año de la publicación del libro: ");
                anyo = Console.ReadLine();
                    
                if(!EsNumero(anyo))
                {
                    numeroValido = false;
                    Console.WriteLine("Error, debe introducir un número, Pulse enter para continuar..");
                    Console.ReadLine();
                }
                else if(Convert.ToInt32(anyo) < 1900 || Convert.ToInt32(anyo) > 2030)
                {
                    numeroValido = false;
                    Console.WriteLine("Error, el año de poblicación debe estar comprendido entre 1900 y 2030. Pulse enter para continuar..");
                    Console.ReadLine();
                }
                else
                {
                    numeroValido = true;
                }
            } while (!numeroValido);

            if (cantidad < capacidad)
            {
                libros[cantidad] = new Libro(nombre, genero, autor, anyo);
                cantidad++;
            }
            Console.WriteLine("La pelicula se ha añadido correctamente. Pulsa enter para continuar..");
            Console.ReadLine();
            Console.Clear();
        }
        public static bool EsNumero(string texto)
        {
            if(texto == "")
            {
                return false;
            }

            foreach(char caracter in texto)
            {
                if( caracter < '0' || caracter > '9')
                {
                    return false;
                }
            }
            return true;
        }
        public static string PedirTextoObligatorio(string nombreCampo)
        {
            string texto;
            do
            {
                Console.Write(nombreCampo + ": ");
                texto = Console.ReadLine();

                if (texto == "")
                {
                    Console.WriteLine("El " + nombreCampo + " es un campo obligatorio. Pulse enter para continuar..");
                    Console.ReadLine();
                }
                Console.Clear();

            } while (texto == "");
            return texto;
        }
        public static void MostrarLibro()
        {
            Console.WriteLine("Los libros guardados son: ");
            PintarCabeceras();


            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine((i + 1) + ". " + libros[i].ToString());
            }
            Console.WriteLine();
            Console.Write("Pulse enter para continuar..");
            Console.ReadLine();
            Console.Clear();
        }
        public static void EliminarLibro()
        {
            int posicionBorrar = -1;

            do
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine((i + 1) + ". " + libros[i].ToString());
                }
                Console.WriteLine("¿Qué libro quieres eliminar?");

                try
                {
                    posicionBorrar = Convert.ToInt32(Console.ReadLine());

                    if (posicionBorrar > cantidad || posicionBorrar <= 0)
                    {
                            Console.WriteLine("Error, el número que ha introducido no coincide con ningún libro. Pulse enter para continuar..");
                    }
                    else
                    {
                        for (int i = posicionBorrar -1; i < cantidad; i++)
                        {
                            libros[i] = libros[i + 1];
                        }
                        cantidad--;
                        Console.WriteLine();
                        Console.Write("Libro borrado correctamente. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, debes introducir un numero. Pulse enter para continuar");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (posicionBorrar > cantidad || posicionBorrar <= 0);
        }
        public static void ModificarLibro()
        {
            int posicionModificar = -1;
            do
            {
                PintarCabeceras();

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine((i + 1) + ". " + libros[i].ToString());
                }
                Console.WriteLine("¿Qué libro quieres modificar?");

                try
                {
                    posicionModificar = Convert.ToInt32(Console.ReadLine()); 

                    if (posicionModificar > cantidad || posicionModificar <= 0)
                    {
                        Console.WriteLine("Error, el número introducido no coincide con ningún libro");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Editando el libro: ");

                        Console.WriteLine("Nombre: " + libros[posicionModificar - 1].Nombre);
                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();

                        if (nuevoNombre != "")
                        {
                            libros[posicionModificar - 1].Nombre = nuevoNombre;
                        }

                        Console.WriteLine("Género: " + libros[posicionModificar - 1].Genero);
                        Console.Write("Nuevo género: ");
                        string nuevoGenero = Console.ReadLine();

                        if (nuevoGenero != "")
                        {
                            libros[posicionModificar - 1].Genero = nuevoGenero;
                        }

                        Console.WriteLine("Autor: " + libros[posicionModificar - 1].Autor);
                        Console.Write("Nuevo autor: ");
                        string nuevoAutor = Console.ReadLine();

                        if (nuevoAutor != "")
                        {
                            libros[posicionModificar - 1].Autor = nuevoAutor;
                        }

                        Console.WriteLine("Año Publicación: " + libros[posicionModificar - 1].AnyoPublicacion);
                        Console.Write("Nuevo año: ");
                        string nuevoAnyo = Console.ReadLine();

                        if (nuevoAnyo != "")
                        {
                            libros[posicionModificar - 1].AnyoPublicacion = nuevoAnyo;
                        }
                        Console.WriteLine();
                        Console.Write("Libro editado correctamente. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, debes introducir un numero. Pulse enter para continuar");
                    Console.ReadLine();
                }
                

            } while (posicionModificar > cantidad || posicionModificar <= 0);
        }
        public static void BucarLibro()
        {
            string buscarLibro;

            Console.WriteLine("Qué libro quieres buscar?");
            buscarLibro= Console.ReadLine();
            bool libroEncontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (libros[i].Nombre.Contains(buscarLibro))
                {
                    libroEncontrado = true;
                    break;
                }
            }
            if (libroEncontrado)
            {
                Console.WriteLine("Ese libro está guardado. Pulse enter para continuar..");
            }
            else
            {
                Console.WriteLine("Ese libro no está guardado. Pulse enter para continuar..");
            }
            Console.ReadLine();
        }
        public static void PintarCabeceras()
        {
            Console.WriteLine(("   Nombre").PadRight(33) +
                ("Genero").PadRight(20) +
                ("Actor").PadRight(20) +
                "Año");
        }
       /*public static void IntroducirDatosPrueba()
        {
            cantidad = 3;
            libros[0] = new Libro("el rey leon", "dibujos", "simba", "1985");
            libros[1] = new Libro("harry potter", "fantasia", "harry", "1999");
            libros[2] = new Libro("los juegos del hambre", "accion", "katniss", "2010");
        }*/
        public static void GuardarLibros()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Sonia\\Desktop\\Ejercicios C#\\libreria\\libreria\\libros.txt"))
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        sw.WriteLine(libros[i].Nombre + ";" +
                                     libros[i].Genero + ";" +
                                     libros[i].Autor + ";" +
                                     libros[i].AnyoPublicacion);
                    }
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static void CargarLibros()
        {
            String linea;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                using (StreamReader sr = new StreamReader("C:\\Users\\Sonia\\Desktop\\Ejercicios C#\\libreria\\libreria\\libros.txt"))
                {
                    //Read the first line of text
                    linea = sr.ReadLine();
                    //Continue to read until you reach end of file
                    while (linea != null)
                    {
                        string[] libroPartido = linea.Split(';');
                        libros[cantidad] = new Libro(libroPartido[0], libroPartido[1], libroPartido[2], libroPartido[3]);
                        cantidad++;
                        linea = sr.ReadLine();
                    }
                }                   
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        //Pintar cuantos libros hay de cada genero   fansia: 2 // accion: 3
        public static void MostrarGenerosLibros()
        {
            Dictionary<string, int> generosLibros = new Dictionary<string, int>();

            for (int i = 0; i < cantidad; i++)
            {
                if (generosLibros.ContainsKey(libros[i].Genero))
                {
                    generosLibros[libros[i].Genero]++;
                }
                else
                {
                    generosLibros.Add(libros[i].Genero, 1);
                }
            }
            foreach (string genero in generosLibros.Keys)
            {
                Console.WriteLine(genero + ": " + generosLibros[genero]);
            }
        }
    }
}
