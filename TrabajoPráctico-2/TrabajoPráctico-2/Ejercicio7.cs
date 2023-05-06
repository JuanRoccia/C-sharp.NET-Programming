// Ejercicio 7: Realice un programa que lea una palabra ingresada por el usuario y muestre en pantalla la misma palabra pero sin vocales.
using System;

namespace TrabajoPractico_2
{
    public class Ejercicio7
    {
        public static void Resolver()
        {
            // Guardar palabra ingresada
            Console.WriteLine("Ingresar palabra: ");
            string palabra = Console.ReadLine();

            // Eliminar vocales
            string palabraSinVocales = "";
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char letra in palabra)
            {
                if (Array.IndexOf(vocales, letra) == -1)
                {
                    palabraSinVocales += letra;
                }
            }

            // Mostrar en pantalla
            Console.WriteLine("Palabra sin vocales: " + palabraSinVocales);
        }

    }
}
