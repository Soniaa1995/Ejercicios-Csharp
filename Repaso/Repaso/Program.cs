using System;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumarEnteros(2, 5));
            SumarNumeros(3, 4);
            Console.WriteLine(SumarNum());
            SumarNums();
        }

        //1) funcion que recibe 2 numeros enteros como parametro y devuelve el resultado de la suma entre los 2 numeros

        public static int SumarEnteros(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        //2) funcion que recibe 2 numeros enteros como parametros y pinta por consola el resultadao de la suma entre los 2 numeros

        public static void SumarNumeros(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine("La sume de " + numero1 + " + " + numero2 + " = " + resultado);
        }

        //3) funcion que pide al usuario que introduzca un numero entero y luego otro y devuelve el resultado de la suma entre los 2 numeros

        public static int SumarNum()
        {
            int numero1;
            int numero2;
            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = numero1 + numero2;
            return resultado;
        }

        //4) funcion que pide al usuario que introduzca un numero entero y luego otro y pinta por consola el resultado de la suma entre los 2 numeros
        public static void SumarNums()
        {
            int numero1;
            int numero2;
            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = numero1 + numero2;

            Console.WriteLine("La sume de " + numero1 + " + " + numero2 + " = " + resultado);
        }
    }
}
