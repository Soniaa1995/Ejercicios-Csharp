using System;
using System.IO;

namespace GuardarFichero
{
    class Program
    {
        static int capacidad = 50;
        static int cantidad = 0;
        static Pelicula[] peliculas = new Pelicula[capacidad];

        static void Main(string[] args)
        {
            CargarDatos();
            MostrarMenu();
        }

        static void MostrarMenu() 
        {
            bool salir = false;

            do
            {
                Console.WriteLine("Bienvenido. ¿Qué opción quiere realizar?");
                Console.WriteLine("1. Añadir una pelicula");
                Console.WriteLine("2. Mostrar todas las peliculas");
                Console.WriteLine("3. Editar una pelicula");
                Console.WriteLine("4. Eliminar una pelicula");
                Console.WriteLine("5. Buscar una pelicula");
                Console.WriteLine("6. Salir");

                string opcion = Console.ReadLine(); 
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        AnyadirPelicula();
                        GuardarDatos();
                        break;

                    case "2":
                        MostrarPelicula();
                        break;

                    case "3":
                        EditarPelicula();
                        GuardarDatos();
                        break;

                    case "4":
                        EliminarPelicula();
                        GuardarDatos();
                        break;

                    case "5":
                        BuscarPelicula();
                        break;
                        
                    case "6":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Error, debes elegir una opción entre la 1 y la 5.");
                        Console.ReadLine();
                        break;
                }
            } while(!salir);
        }

        public static void AnyadirPelicula()
        {
            Console.WriteLine("Añadiendo película: ");
            string nombre;
            string genero;
            string director;
            string actores;
            string anyo = "";

            do
            {
                Console.Write("Escribe el nombre: ");
                nombre = Console.ReadLine();

                if(nombre == "")
                {
                    Console.Write("El nombre es un campo obligatorio. Pulsa enter para continuar..");
                    Console.ReadLine();
                }
            } while (nombre == "");

            do
            {
                Console.Write("Escribe el género: ");
                genero = Console.ReadLine();

                if (genero == "")
                {
                    Console.Write("El género es un campo obligatorio. Pulsa enter para continuar..");
                    Console.ReadLine();
                }
            } while (genero == "");

            Console.Write("Escribe el nombre del director: ");
            director = Console.ReadLine();

            Console.Write("Escribe el nombre del protagonista: ");
            actores = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("Año de la pelicula: ");
                    int anyoTemp = Convert.ToInt32(Console.ReadLine());

                    if(anyoTemp >= 1900 && anyoTemp <= 2030)
                    {
                        anyo = Convert.ToString(anyoTemp);
                    }
                    else
                    {
                        Console.Write("El año debe estar comprendido entre 1900 y 2030. Pulsa enter para continuar..");
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.Write("El año es un campo obligatorio y se debe de poner un número. Pulsa enter para continuar..");
                    Console.ReadLine();
                }
            } while (anyo == "");
                
            if (cantidad < capacidad)
            {
                peliculas[cantidad] = new Pelicula(nombre, genero, director, actores, anyo);
                cantidad++;
            }

            Console.WriteLine("La pelicula se ha añadido correctamente. Pulsa enter para continuar..");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MostrarPelicula()
        {
            Console.WriteLine("Las peliculas guardadas son: ");

            PintarCabeceras();

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine((i + 1) + ". " + peliculas[i].ToString());
            }
            Console.WriteLine();
            Console.Write("Pulse enter para continuar..");
            Console.ReadLine();
            Console.Clear();
        }

        public static void EditarPelicula()
        {
            int editarPelicula = -1;
            do
            {
                PintarCabeceras();

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine((i + 1) + ". " + peliculas[i].ToString());
                }
                Console.WriteLine("¿Qué pelicula quieres editar?: ");
                try
                {
                    editarPelicula = Convert.ToInt32(Console.ReadLine());

                    if (editarPelicula > cantidad || editarPelicula <= 0)
                    {
                        Console.WriteLine("Error, debes introducir el numero correcto. Pulse enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Película a editar");

                        Console.WriteLine("Nombre actual: " + peliculas[editarPelicula - 1].Nombre);
                        Console.Write("Nombre nuevo: ");
                        string nombre = Console.ReadLine();

                        if (nombre != "")
                        {
                            peliculas[editarPelicula - 1].Nombre = nombre;
                        }

                        Console.WriteLine("Genero actual: " + peliculas[editarPelicula - 1].Genero);
                        Console.Write("Genero nuevo: ");
                        string genero = Console.ReadLine();

                        if (genero != "")
                        {
                            peliculas[editarPelicula - 1].Genero = genero;
                        }

                        Console.WriteLine("Director actual: " + peliculas[editarPelicula - 1].Director);
                        Console.Write("Director nuevo: ");
                        string director = Console.ReadLine();

                        if (director != "")
                        {
                            peliculas[editarPelicula - 1].Director = director;
                        }

                        Console.WriteLine("Actores actual: " + peliculas[editarPelicula - 1].Actores);
                        Console.Write("Genero nuevo: ");
                        string actores = Console.ReadLine();

                        if (actores != "")
                        {
                            peliculas[editarPelicula - 1].Actores = actores;
                        }

                        Console.WriteLine("Año actual: " + peliculas[editarPelicula - 1].Anyo);
                        Console.Write("Genero nuevo: ");
                        string anyo = Console.ReadLine();

                        if (anyo != "")
                        {
                            peliculas[editarPelicula - 1].Anyo = anyo;
                        }

                        Console.WriteLine();
                        Console.Write("Pelicula editada correctamente. Pulse enter para continuar..");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, debes introducir un numero. Pulse enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (editarPelicula > cantidad || editarPelicula <= 0);
        }

        public static void EliminarPelicula()
        {
            int borrarPelicula = -1;
            do
            {
                PintarCabeceras();

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine((i + 1) + ". " + peliculas[i].ToString());
                }
                Console.WriteLine("¿Qué pelicula quieres eliminar?: ");
                try
                {
                    borrarPelicula = Convert.ToInt32(Console.ReadLine());

                    if (borrarPelicula > cantidad || borrarPelicula <= 0)
                    {
                        Console.WriteLine("Error, debes introducir el numero correcto. Pulse enter para continuar");
                        Console.ReadLine();
                    }
                    else
                    {
                        for (int i = borrarPelicula - 1; i < cantidad; i++)
                        {
                            peliculas[i] = peliculas[i + 1];
                        }
                        cantidad--;

                        Console.WriteLine();
                        Console.Write("Pelicula borrada correctamente. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, debes introducir un numero. Pulse enter para continuar");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (borrarPelicula > cantidad || borrarPelicula <= 0);
        }

        public static void BuscarPelicula()
        {
            string buscaNombrePeli;
            bool existePeli = false;
            for(int i = 0; i < cantidad; i++) 
            {
                Console.WriteLine("¿Qué película quieres buscar?");
                buscaNombrePeli = Console.ReadLine();    

                if (peliculas[i].Nombre == buscaNombrePeli)
                {
                    Console.WriteLine("La pelicula se ha encontrado");
                    existePeli= true;
                }
            }
            Console.WriteLine(existePeli);
        }

        public static void IntroducirDatosPrueba()
        {
            cantidad = 43;
            peliculas[0] = new Pelicula("el rey leon", "fdssfs", "dadad", "asdd", "2000");
            peliculas[1] = new Pelicula("harry potter", "fdssfs", "dadad", "asdd", "2000");
            peliculas[2] = new Pelicula("piratas del caribe", "fdssfs", "dadad", "asdd", "2000");

            for (int i = 3; i < 43; i++)
            {
                peliculas[i] = new Pelicula("piratas del caribe" + i, "fdssfs", "dadad", "asdd", "2000");
            }
        }

        public static void PintarCabeceras()
        {
            Console.WriteLine(("   Nombre").PadRight(33) + 
                ("Genero").PadRight(30) + 
                ("Director").PadRight(20) + 
                ("Actores").PadRight(20) + 
                 "Año");
        }

        public static void CargarDatos()
        {
            String linea;
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Sonia\\Desktop\\Ejercicios C#\\GuardarFichero\\GuardarFichero\\peliculas.txt"))
                {
                    linea = sr.ReadLine();

                    while (linea != null)
                    {
                        string[] peliculaPartida = linea.Split(';');
                        peliculas[cantidad] = new Pelicula(peliculaPartida[0], peliculaPartida[1], peliculaPartida[2], peliculaPartida[3], peliculaPartida[4]);
                        cantidad++;

                        linea = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static void GuardarDatos()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Sonia\\Desktop\\Ejercicios C#\\GuardarFichero\\GuardarFichero\\peliculas.txt"))
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        sw.WriteLine(peliculas[i].Nombre + ";" +
                                     peliculas[i].Genero + ";" +
                                     peliculas[i].Director + ";" +
                                     peliculas[i].Actores + ";" +
                                     peliculas[i].Anyo);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
