using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


namespace Ejercicios_pdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea un programa que pida al usuario un número entero y diga si es par
            //(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero:
            //if (x % 2 == 0) …).

            /*
            Console.Write("Dime un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0 )
            {
                Console.WriteLine("El número introducido es par");
            }
            else
            {
                Console.WriteLine("El número introducido no es par");
            }
            Console.ReadLine();*/

            //Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.
            /*
            Console.Write("Dime un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dime otro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 > numero2)
            {
                Console.WriteLine("El " + numero1 + " es mayor que el " + numero2);
            }
            else
            {
                Console.WriteLine("El " + numero2 + " es mayor que el " + numero1);
            }
            Console.ReadLine();*/

            //Crea un programa que pida al usuario dos números enteros y diga si el
            //primero es múltiplo del segundo(pista: igual que antes, habrá que ver si el resto
            //de la división es cero: a % b == 0)
            /*
            Console.Write("Dime un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dime otro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1  % numero2  == 0)
            {
                Console.WriteLine("El " + numero1 + " es multiplo de " + numero2);
            }
            else
            {
                Console.WriteLine("El " + numero1 + " NO es multiplo de " + numero2);
            }
            Console.ReadLine();*/

            //Crea un programa que pida al usuario dos números enteros. Si el
            //segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo.
            //Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero"
            /*
            Console.Write("Dime un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dime otro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int division;

            if (numero2 != 0)
            {
                division = numero1 / numero2;
                Console.WriteLine(division);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre 0");
            }
            Console.ReadLine();*/

            //Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 o de 3.
            /*
            Console.Write("Dime un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0 || numero1 % 3 == 0)
            {
                Console.WriteLine("El número introducido es múltiplo de 2 o de 3");
            }
            Console.ReadLine();*/

            //Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 pero no de 3.

            /*
            Console.Write("Dime un número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0 || numero1 % 3 != 0)
            {
                Console.WriteLine("El número introducido es múltiplo de 2");
            }
            else
            {
                Console.WriteLine("El número introducido NO es múltiplo de 2");
            }
            Console.ReadLine();*/

            //Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
            //nombre de ese número, usando "switch"(por ejemplo, si introduce "1", el
            //programa escribirá "uno").
            /*
            Console.Write("Dime un número del 1 al 5: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1: Console.WriteLine("Número uno");
                    break; 
                case 2: Console.WriteLine("Número dos");
                    break;
                case 3: Console.WriteLine("Número tres");
                    break;
                case 4: Console.WriteLine("Número cuatro");
                    break;
                case 5: Console.WriteLine("Número cinco");
                    break;
            }
            Console.ReadLine();*/

            // Crea un programa que lea una letra tecleada por el usuario y diga si se
            //trata de un signo de puntuación(. , ; :), una cifra numérica(del 0 al 9) o algún otro
            //carácter, usando "switch"(pista: habrá que usar un dato de tipo "char")
            /*
            char tecla;
            string cadena;

            Console.Write("Introduce un caracter: ");
            cadena = Console.ReadLine();

            tecla = char.Parse(cadena);

            switch (tecla)
            {
                case'1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    Console.WriteLine("Es un número");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es una vocal");
                    break;
                default:
                    Console.WriteLine("Es una consonante");
                    break;
            }
            Console.ReadLine();*/

            // Crea un programa que pida al usuario su contraseña (numérica).
            //Deberá terminar cuando introduzca como contraseña el número 1111, pero
            //volvérsela a pedir tantas veces como sea necesario.
            /*
            int contrasenya;

            Console.Write("Introduce la contraseña (para salir introduce 1111: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());  

            while(contrasenya != 1111) 
            { 
                if (contrasenya != 1111)
                {
                    Console.WriteLine("La contraseña ingresada no es correcta");
                }
                else
                {
                    Console.WriteLine("La contraseña ingresada NO es correcta");
                }

                Console.Write("Introduce la contraseña (para salir introduce 1111: ");
                contrasenya = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();*/

            //Crea un "calculador de cuadrados": pedirá al usuario un número y
            //mostrará su cuadrado.Se repetirá mientras el número introducido no sea cero
            //(usa "while" para conseguirlo).

            /*
            int numero = -1;

            while(numero != 0)
            {
                Console.WriteLine("Introduce un número para saber su cuadrado");
                numero = Convert.ToInt32(Console.ReadLine());

                int resultado = numero * numero;    
         
                Console.WriteLine("El resultado de la operación es: " + resultado);
            }
            Console.ReadLine();*/

            //Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto (por ejemplo, 3)
            //y escriba un rectángulo formado por esa cantidad de asteriscos:
            /*
            int alto;
            int ancho;

            Console.Write("Introduce la altura del cuadrado: ");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el ancho del cuadrado: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < alto; i++)
            {

                for(int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();*/


            //Crea un programa que cuente cuantas veces aparece la letra 'a' en una frase que teclee el usuario, utilizando "foreach".
            /*
            string frase;
            char buscarVocal = 'a';
            int contador = 0;

            Console.WriteLine("Escribe una frase: ");
            frase = Console.ReadLine().ToLower();

            foreach(char vocal in frase) 
            {
                if(vocal == buscarVocal)
                {
                    contador++;
                }
            }
            Console.WriteLine("La frase tiene " + contador + " a");
            Console.ReadLine();*/

            //Crea un programa que "dibuje" un triángulo decreciente, con la altura que indique el usuario.
            //Por ejemplo, si el usuario dice que desea 4 caracteres de alto, el triángulo sería así:
            /*
            int alto;

            Console.Write("Introduce la altura del cuadrado: ");
            alto = Convert.ToInt32(Console.ReadLine());

            //decreciente
            for(int i = 1; i <= alto; i++) 
            { 
                for(int j = i; j <= alto ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //creciente
            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            //Un programa que pida al usuario 4 números, los memorice (utilizando un array), calcule su media aritmética
            //y después muestre en pantalla la media y los datos tecleados.
            /*
            int[] numeros = new int[4];

            int suma = 0;
            int media;
            
            for(int i = 0; i< numeros.Length; i++)
            {
                Console.Write("Intoduce el numero " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                suma += numeros[i];
            }

            for(int i = 0;i<numeros.Length;i++)
            {
                Console.WriteLine("Los numeros introducidos son: " + numeros[i]);
            }
            media = suma / 4;
            Console.WriteLine("La media de los números introducidos es de: " + media);*/

            //Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float")
            //y luego los muestre en el orden contrario al que se introdujeron.
            /*
            int tamanyo = 5;
            float[] numeros = new float[tamanyo];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduce el número " +  (i + 1) + ": ");
                numeros[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Los números invertidos son: ");

            for(int i = tamanyo - 1; i >= 0; i--) 
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadLine();*/

            //
        }
    }
}
