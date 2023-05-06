// Ejercicio 1: Se requiere hallar el mayor y el menor de un conjunto de 5 números ingresados por el usuario.
using System;

namespace TrabajoPractico_2
{
    public class Ejercicio1
    {
        public static void Resolver()
        {
            // Array para los números ingresados
            int[] numeros = new int[5];
            // Pedimos al usuario que ingrese el numero
            Console.WriteLine("Ingresa los 5 números, uno por línea: ");
            // Leer cada numero y guardarlo en el array
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Hallar el mayor
            int mayor = numeros.Max();
            // Hallar el menor
            int menor = numeros.Min();

            // Mostrar el numero
            Console.WriteLine("El número mayor: {0}, y el menor: {1}", mayor, menor);


            // EJERCICIO 1 ( OPCION 2 )
            // Variables para los números ingresados
            //    int num1, num2, num3, num4, num5;
            //    // Variables para el mayo y menor
            //    int mayor, menor;

            //    // Pedimos al usuario que ingrese el numero
            //    Console.WriteLine("Ingresa los 5 números, uno por línea: ");

            //    // Leer los números
            //    num1 = int.Parse(Console.ReadLine());
            //    num2 = int.Parse(Console.ReadLine());
            //    num3 = int.Parse(Console.ReadLine());
            //    num4 = int.Parse(Console.ReadLine());
            //    num5 = int.Parse(Console.ReadLine());

            //    // Hallar el mayor
            //    mayor = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));
            //    // Hallar el menor
            //    menor = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));

            //    // Mostrar el numero
            //    Console.WriteLine("El número mayor: {0}, y el menor: {1}", mayor, menor);
        }
    }
}
