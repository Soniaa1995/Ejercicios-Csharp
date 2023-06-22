using System;

namespace Ejercicios_Intermedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios con arrays

            // 1) Crea un array de 10 posiciones, con valores puestos por ti y muestra el array
            /*
            int[] numeros = { 2, 4, 7, 8, 9, 10, 12 };

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadLine();*/

            // 2) Crea un array de 10 posiciones, pide los valores por consola y muestra el array.
            /*
            int[] numeros = new int [10];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Escribe el numero " + (i + 1) + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numero;
            }
            Console.WriteLine("Se muestra el array");
            for(int i = 0; i < numeros.Length;i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadLine();*/


            //3) Sumar los valores de un array y mostrar el resultado.
            /*
            int[] numeros = { 1, 2, 3, 4, 5, };

            int suma = 0;

            for(int i = 0; i < numeros.Length; i++)
            {
                suma+= numeros[i];
            }
            Console.WriteLine("la suma es: " + suma);

            Console.ReadLine();*/

            //4) Hacer la media de los valores de un array y mostrar el resultado.
            /*
            int[] numeros = { 1, 2, 3, 4, 5, };

            int suma = 0;
            int media;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            media = suma / numeros.Length;
            Console.WriteLine("la media es: " + media);

            Console.ReadLine();*/

            //5) Pedir un numero por teclado y multiplicar todos los valores de un array y mostrar el array.
            /*
            int[] numeros = { 1, 2, 3, 4, 5, };

            Console.Write("Dime un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());*/

            //6) Dado un array de numeros con el metodo Sort, ordenalos y muestra su contenido.
            /*
            int[] numeros = { 6, 2, 9, 7, 3, 1};

            Array.Sort(numeros);

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadLine();*/

            //7)  Dado un array de números, muestra el mayor y el menor
            /*
            int[] numeros = { 6, 2, 9, 7, 3, 1 };

            Array.Sort(numeros);

            int maximo = numeros[numeros.Length - 1];
            int minimo = numeros[0];

            Console.WriteLine("El numero máximo es: " + maximo);
            Console.WriteLine("El número mínimo es: " + minimo);

            Console.ReadLine();*/

            //8) El usuario debe introducir un número correspondiente a cierto mes (un valor entre 1 y 12)
            //y la aplicación debe mostrar el nombre del mes correspondiente a dicho número.
            //Para resolver el ejercicio utilizaremos un array de strings dónde cada una de las posiciones del array será cada uno de los meses del año.
            /*
            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            string numero;
            Console.Write("Escribe un número del 1 al 12: ");
            numero = Console.ReadLine();   

            Console.WriteLine("El " + numero + " corresponde a: " + meses[Convert.ToInt32(numero) - 1]);
            Console.ReadLine();*/

            //9) Encontrar el valor maximo de un array
           
            int[] numeros = { 6, 2, 9, 7, 3, 1 };
            int maximo = numeros[0];

            for(int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo= numeros[i];
                }
            }
            Console.WriteLine("El valor maximo del array es: " + maximo);
        }
    }
}
