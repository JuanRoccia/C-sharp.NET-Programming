// Ejercicio 6: Se necesita ingresar el listado de calificaciones de un curso, y obtener el número de 
// aprobados, de desaprobados, la calificación más alta, y el promedio.
using System;

namespace TrabajoPractico_2
{
    public class Ejercicio6
    {
        public static void Resolver()
        {
            // Declaración de variables
            int aprobados = 0; // Cantidad de numeros en el listado >= que 6
            int desaprobados = 0; // Cantidad de numeros en el listado < que 6
            double alta = 0; // Calificación más alta
            double sumaNotas = 0; // La suma de las notas para calcular el promedio
            double promedio; // Promedio de las notas

            // Consultar cuantos alumnos son
            Console.WriteLine("Ingrese la cantidad de alumnos:");
            int alumnos = int.Parse(Console.ReadLine());

            // Crear el arreglo de calificaciones según la cantidad de alumnos
            double[] listado = new double[alumnos];

            // Ingresar las notas que sean necesarias al listado según la cantidad de alumnos
            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"Ingrese la calificación del alumno {i + 1}:");
                double nota = double.Parse(Console.ReadLine());
                listado[i] = nota;

                // Actualizar las estadísticas
                if (nota >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }

                if (nota > alta)
                {
                    alta = nota;
                }

                sumaNotas += nota;
            }

            // Calcular el promedio
            promedio = (double)sumaNotas / alumnos;

            // Mostrar resultados
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Desaprobados: {desaprobados}");
            Console.WriteLine($"Calificación más alta: {alta}");
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}

