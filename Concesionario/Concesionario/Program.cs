using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Concesionario
{
    class Program
    {
        static int cantidad = 0;
        static int capacidad = 5;
        static Coche[] coches = new Coche[capacidad];
        static string rutaTexto = "C:\\Users\\la_so\\OneDrive\\Escritorio\\Ejercicios C#\\Concesionario\\Concesionario\\coches.txt";
        static void Main(string[] args)
        {
            //DatosPrueba();
            CargarDatos();
            MostrarMenu();
        }
        
        static void MostrarMenu()
        {
            string opcion;

            do
            {
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.WriteLine("1. Añadir un coche");
                Console.WriteLine("2. Mostrar todos los coches");
                Console.WriteLine("3. Editar un coche");
                Console.WriteLine("4. Eliminar un coche");
                Console.WriteLine("5. Buscar un coche");
                Console.WriteLine("6. Media de km de los coches");
                Console.WriteLine("7. Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AnyadirCoche();
                        GuardarDatos();
                        break;
                    case "2":
                        MostrarCoche(true);
                        break;
                    case "3":
                        EditarCoche();
                        GuardarDatos();
                        break;
                    case "4":
                        EliminarCoche();
                        GuardarDatos();
                        break;
                    case "5":
                        BuscarCoche();
                        break;
                    case "6":
                        Console.WriteLine();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Error, debe introducir un número entre el 1 y el 7");
                        break;
                }
            } while (opcion != "7");
        }

        public static void DatosPrueba()
        {
            cantidad = 3;
            coches[0] = new Coche("KLM1023", "Citroen", "C2", "Gasolina", 30000);
            coches[1] = new Coche("HNB526", "Peugot", "308", "Hibrido", 100000);
            coches[2] = new Coche("LMN587", "Renault", "Clio", "Diesel", 250000);
        }

        public static void AnyadirCoche()
        {
            if(cantidad < capacidad)
            {
                string matricula;
                string marca;
                string modelo;
                string combustible;
                int kilometros = 0;

                do
                {
                    Console.Write("Introduce la matricula del coche:");
                    matricula = Console.ReadLine();

                    if (matricula == "")
                    {
                        Console.WriteLine("Error, este campo es obligatorio de rellenar. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                } while (matricula == "");

                do
                {
                    Console.Write("Introduce la marca del coche:");
                    marca = Console.ReadLine();

                    if (marca == "")
                    {
                        Console.WriteLine("Error, este campo es obligatorio de rellenar. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                } while (marca == "");

                do
                {
                    Console.Write("Introduce el modelo del coche:");
                    modelo = Console.ReadLine();

                    if (modelo == "")
                    {
                        Console.WriteLine("Error, este campo es obligatorio de rellenar. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                } while (modelo == "");

                do
                {
                    Console.WriteLine("Estos son los tipos de combustible disponible:");
                    Console.WriteLine("1. Gasolina");
                    Console.WriteLine("2. Diesel");
                    Console.WriteLine("3. Hibrido");
                    Console.WriteLine("4. Electrico");

                    combustible = Console.ReadLine();

                    switch (combustible)
                    {
                        case "1":
                            combustible = "Gasolina";
                            break;
                        case "2":
                            combustible = "Diesel";
                            break;
                        case "3":
                            combustible = "Hibrido";
                            break;
                        case "4":
                            combustible = "Electrico";
                            break;
                        default:
                            Console.WriteLine("Error, debe elegir una de las opciones mostradas.");
                            break;
                    }

                    if (combustible == "")
                    {
                        Console.WriteLine("Error, este campo es obligatorio de rellenar. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                } while (combustible == "");

                do
                {
                    Console.Write("Introduce los kilometros del coche:");
                    try
                    {
                        kilometros = Convert.ToInt32(Console.ReadLine()); 

                        if(kilometros <= 0)
                        {
                            Console.WriteLine("Error, este campo es obligatorio de rellenar. Pulse enter para continuar..");
                            Console.ReadLine();
                        }
                    }catch (Exception e) 
                    {
                        Console.WriteLine("Error, debes introducir un número");
                    }
                } while (kilometros <= 0);

                coches[cantidad] = new Coche(matricula, marca, modelo, combustible, kilometros);
                cantidad++;

                Console.WriteLine("Bien, el coche ha sido guardado corrextamente");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No puede introducir más coches. Ha llenado toda la capacidad. Pulse enter para continuar..");
                Console.ReadLine();
            }
            Console.Clear();
        }

        public static void MostrarCoche(bool mostrar)
        {
            Console.WriteLine("Estos son los coches guardados: ");

            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine((1 + i) + ". " + coches[i].ToString());
            }
            
            if(mostrar)
            {
                Console.WriteLine("Pulse enter para continuar..");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void EliminarCoche()
        {
            int posicionBorrar = -1;

            do
            {
                MostrarCoche(false);
                Console.WriteLine("Elige la opción que quieres eliminar");

                try
                {
                    posicionBorrar = Convert.ToInt32(Console.ReadLine());

                    if (posicionBorrar > cantidad || posicionBorrar <= 0)
                    {
                        Console.WriteLine("Error, debe elegir una de las opciones mostradas. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                    else
                    {
                        for(int i = posicionBorrar -1; i < cantidad; i++)
                        {
                            coches[i] = coches[i + 1];
                        }
                        cantidad--;
                        Console.WriteLine("Coche borrado correctamente. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Error, debe elegir una de las opciones mostradas. Pulse enter para continuar..");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (posicionBorrar > cantidad || posicionBorrar <= 0);
        }

        public static void EditarCoche()
        {
            int posicionEditar = -1;

            do
            {
                MostrarCoche(false);
                Console.WriteLine("Elige la opción que quieres editar");

                try
                {
                    posicionEditar = Convert.ToInt32(Console.ReadLine());

                    if (posicionEditar > cantidad || posicionEditar <= 0)
                    {
                        Console.WriteLine("Error, debe elegir una de las opciones mostradas. Pulse enter para continuar..");
                        Console.ReadLine();
                    }
                    else
                    {
                        string nuevaMatricula;
                        Console.WriteLine("El nombre de la matricula anterior: " + coches[posicionEditar -1].Matricula);
                        Console.WriteLine("La nueva matricula es: ");
                        nuevaMatricula = Console.ReadLine();

                        if(nuevaMatricula != "")
                        {
                            coches[posicionEditar -1].Matricula = nuevaMatricula;
                        }

                        string nuevaMarca;
                        Console.WriteLine("El nombre de la marca anterior: " + coches[posicionEditar - 1].Marca);
                        Console.WriteLine("La nueva marca es: ");
                        nuevaMarca = Console.ReadLine();

                        if (nuevaMarca != "")
                        {
                            coches[posicionEditar - 1].Marca = nuevaMarca;
                        }

                        string nuevaModelo;
                        Console.WriteLine("El nombre del modelo anterior: " + coches[posicionEditar - 1].Modelo);
                        Console.WriteLine("El nuevo modelo es: ");
                        nuevaModelo = Console.ReadLine();

                        if (nuevaModelo != "")
                        {
                            coches[posicionEditar - 1].Marca = nuevaModelo;
                        }

                        bool error;
                        do
                        {
                            string nuevoCombustible;
                            error = false;
                            Console.WriteLine("El nombre del combustible anterior: " + coches[posicionEditar - 1].Combustible);
                            Console.WriteLine("1. Gasolina");
                            Console.WriteLine("2. Diesel");
                            Console.WriteLine("3. Hibrido");
                            Console.WriteLine("4. Electrico");
                            nuevoCombustible = Console.ReadLine();

                            switch (nuevoCombustible)
                            {
                                case "1":
                                    nuevoCombustible = "Gasolina";
                                    break;
                                case "2":
                                    nuevoCombustible = "Diesel";
                                    break;
                                case "3":
                                    nuevoCombustible = "Hibrido";
                                    break;
                                case "4":
                                    nuevoCombustible = "Electrico";
                                    break;
                                case "":
                                    break;
                                default:
                                    Console.WriteLine("Error, debe elegir una de las opciones mostradas.Pulse enter para continuar..");
                                    Console.ReadLine();
                                    error = true;
                                    
                                    break;
                            }

                            if (nuevoCombustible != "" && !error)
                            {
                                coches[posicionEditar - 1].Combustible = nuevoCombustible;
                            }
                        } while (error);
                        
                        int nuevoKilometros;
                        string stringNuevoKm;

                        do
                        {
                            error = false;
                            Console.WriteLine("El nombre del modelo anterior: " + coches[posicionEditar - 1].Kilometros);
                            Console.WriteLine("Los nuevos kilometros son: ");
                            try
                            {
                                stringNuevoKm = Console.ReadLine();

                                if (stringNuevoKm != "")
                                {
                                    nuevoKilometros = Convert.ToInt32(stringNuevoKm);

                                    if (nuevoKilometros <= 0)
                                    {
                                        Console.WriteLine("Los kilometros deben ser mayor a 0. Pulse enter para continuar..");
                                        Console.ReadLine();
                                        error = true;
                                    }
                                    else
                                    {
                                        coches[posicionEditar - 1].Kilometros = nuevoKilometros;
                                        Console.WriteLine("Coche editado correctamente. Pulse enter para continuar..");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error, debe introducir un numero.Pulse enter para continuar..");
                                Console.ReadLine();
                                error = true;
                            }
                        } while (error);
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, debe elegir una de las opciones mostradas. Pulse enter para continuar..");
                    Console.ReadLine();
                }
                Console.Clear();

            } while (posicionEditar > cantidad || posicionEditar <= 0);

        }

        public static void BuscarCoche()
        {
            string opcion;
            string campo = "";
            bool opcionCorrecta;
            do
            {
                opcionCorrecta = true;
                Console.WriteLine("¿Por qué campo quieres buscar el coche?");
                Console.WriteLine("1. Matricula");
                Console.WriteLine("2. Marca");
                Console.WriteLine("3. Modelo");
                Console.WriteLine("4. Combustible");
                Console.WriteLine("5. Kilometros");
                opcion = Console.ReadLine();
                
                switch(opcion)
                {
                    case "1":
                        campo = "matricula";
                        break;
                    case "2":
                        campo = "marca";
                        break;
                    case "3":
                        campo = "modelo";
                        break;
                    case "4":
                        campo = "combustible";
                        break;
                    case "5":
                        campo = "kilometros";
                        break;
                    default:
                        Console.WriteLine("Debe seleccionar una opción entre el 1 y 5. Pulse enter para continuar..");
                        opcionCorrecta = false;
                        break;
                }
            } while (!opcionCorrecta);

            Console.Write("Escribe el/la " + campo + " que quieres buscar: ");
            string busqueda = Console.ReadLine();
            bool encontrado = false;

            for(int i = 0; i < cantidad; i++)
            {
                if((opcion == "1" && coches[i].Matricula.ToLower() == busqueda.ToLower()) ||
                   (opcion == "2" && coches[i].Marca.ToLower().Contains(busqueda.ToLower())) ||
                   (opcion == "3" && coches[i].Modelo.ToLower().Contains(busqueda.ToLower())) ||
                   (opcion == "4" && coches[i].Combustible.ToLower().Contains(busqueda.ToLower())) ||
                   (opcion == "5" && coches[i].Kilometros.ToString() == busqueda))
                {
                    Console.WriteLine(coches[i].ToString());
                    encontrado = true;
                }
            }
            if(!encontrado)
            {
                Console.WriteLine("No se ha encontrado ningún coche con la búsqueda que ha realizado. Pulse enter para continuar..");
            }
            else
            {
                Console.WriteLine("Pulse enter para continuar..");
            }
            
            Console.ReadLine(); 
            Console.Clear();
        }

        public static void GuardarDatos() 
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = new StreamWriter(rutaTexto))
                {   
                    for(int i =0; i < cantidad; i++)
                    {
                        sw.WriteLine(coches[i].Matricula + ";" +
                            coches[i].Marca + ";" +
                            coches[i].Modelo + ";" +
                            coches[i].Combustible + ";" +
                            coches[i].Kilometros);
                    }
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
                using (StreamReader sr = new StreamReader(rutaTexto))
                {
                    line = sr.ReadLine();
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        string[] lineaSplit = line.Split(';');
                        coches[cantidad] = new Coche(lineaSplit[0], lineaSplit[1], lineaSplit[2], lineaSplit[3], Convert.ToInt32(lineaSplit[4]));
                        cantidad++;
                        //Read the next line
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void MediaKim()
        {

        }
    }
}
