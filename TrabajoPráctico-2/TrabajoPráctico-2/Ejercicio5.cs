// Ejercicio 5: Realice un programa que muestre en pantalla la tabla de multiplicar de un número 
// entre 0 y 10 ingresado por el usuario. La visualización debe ser de la siguiente forma:
// “Tabla del 4:
// 4x0 = 0
// 4x1 = 4
// 4x2 = 8
// 4x3 = 12
// Etc”
using System;

namespace TrabajoPractico_2
{
    public class Ejercicio5
    {
        public static void Resolver()
        {
            // Declaramos variables
            int num;

            // Solicitamos el numero y lo guardamos
            Console.WriteLine("Ingrese un numero entre 0 y 10:");
            num = int.Parse(Console.ReadLine());

            // Validamos que el número esté en el rango [0, 10]
            if (num < 0 || num > 10)
            {
                Console.WriteLine("El número ingresado no está en el rango válido.");
                return;
            }

            // Ejecutamos y mostramos los resultados
            Console.WriteLine($"Tabla del {num}:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num}x{i} = {num * i}");
            }

        }
    }
}
