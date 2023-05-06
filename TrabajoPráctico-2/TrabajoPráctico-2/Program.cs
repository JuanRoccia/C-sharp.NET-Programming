using System;
using System.IO;
using System;

namespace TrabajoPractico_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elija el ejercicio que desea resolver (1-7) o ingrese 'q' para salir:");
                string opcion = Console.ReadLine();

                if (opcion == "q" || opcion == "Q")
                {
                    break;
                }

                switch (opcion)
                {
                    case "1":
                        Ejercicio1.Resolver();
                        break;
                    case "2":
                        Ejercicio2.Resolver();
                        break;
                    case "3":
                        Ejercicio3.Resolver();
                        break;
                    case "4":
                        Ejercicio4.Resolver();
                        break;
                    case "5":
                        Ejercicio5.Resolver();
                        break;
                    case "6":
                        Ejercicio6.Resolver();
                        break;
                    case "7":
                        Ejercicio7.Resolver();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}