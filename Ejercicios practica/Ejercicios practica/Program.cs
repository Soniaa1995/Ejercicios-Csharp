using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Ejercicios_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.

            /*
            int a = 2;
            int b = 3; 
            int c = 5;

            int suma = a + b + c; 
            
            Console.WriteLine("La suma de: " + a + ", " + b + " y " + c + " es = " + suma);*/

            //2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por pantalla,
            //el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>

            /* string nombre;
             string ciudad;

             Console.WriteLine("¿Como te llamas?");
             nombre = Console.ReadLine();

             Console.WriteLine("¿A qué ciudad te diriges?");
             ciudad = Console.ReadLine();    

             Console.WriteLine("Hola " +  nombre + " bienvenido a " + ciudad);*/

            //3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y tienes » <años> » años»
            /*
            string nombre;
            int edad;

            Console.WriteLine("¿Cómo te llamas?");
            nombre = Console.ReadLine();

            Console.WriteLine("¿Cuántos años tienes?");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años");*/

            //4) Pedir dos números al usuario por teclado y decir que número es el mayor.
            /*
            int a;
            int b;

            Console.Write("Introduce un número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro número");
            b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine(a + " es mayor que " + b);
            }
            else
            {
                Console.WriteLine(b + " es mayor que " + a);
            }*/

            //5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.
            /*
            string diaSemana;

            Console.WriteLine("Dime un día de la semana");
            diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Es un día de la semana");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;
                default: 
                    Console.WriteLine("Ese día no existe");
                    break;
            }
            Console.ReadLine();*/

            //6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta,
            //pedir el numero de cuenta (inventado)
            /*
            int precio;
            string formaPago;

            Console.Write("Dime el precio del producto: ");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Cómo quieres pagar?: Con tarjeta o en efectivo?");
            formaPago = Console.ReadLine();

            if(formaPago.Equals("tarjeta"))
            {
                Console.Write("Dime el número de cuenta: ");
               int numeroCuenta = Convert.ToInt32(Console.ReadLine());

                Console.Write("El producto con precio " +  precio + " ha sido pagado con tarjeta con el número de cuenta " + numeroCuenta);
            }
            else if(formaPago == "efectivo")
            {
                Console.WriteLine("El producto con precio " + precio + " se ha pagado en efetivo");
            }
            else
            {
                Console.WriteLine("La forma de pago no es correcta. Por favor, intentelo de nuevo");
            }
            Console.ReadLine(); */

            //7) Recorre los números del 1 al 100. Usa un bucle for.
            /*
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            //8) Recorre los números del 1 al 100. Usa un bucle while.
            /*
            int i = 1;
            while(i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine(); */

            // 9) Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
            /*
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            //10) Recorre los números del 1 al 100.Muestra los números pares o divisibles entre 3.

            for (int i = 0; i <= 100; i ++)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
