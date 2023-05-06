// Ejercicio 3: Escribir un programa que lea 3 letras ingresadas por el usuario y las muestre en el orden inverso.
using System;
using System.Collections;

namespace TrabajoPractico_2
{
    public class Ejercicio3
    {
        public static void Resolver()
        {
            // Pedimos las 3 letras
            string[] letras = new string[3];
            Console.WriteLine("Ingrese las 3 letras: ");

           // Capturamos y guardamos las letras en el array
           for (int i = 0; i < letras.Length; i++)
            {
                Console.Write($"Letra {i + 1}: ");
                letras[i] = Console.ReadLine();
            }

            // Muestra las letras en orden inverso
            Console.Write("Las letras en orden inverso son: ");
            for (int i = letras.Length -1 ;i >= 0; i--)
            {
                Console.Write(letras[i]);
            }
            Console.WriteLine();
        }
    }
}