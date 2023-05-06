// Ejercicio 2: Solicitar al usuario un día de la semana, mostrar la opción seleccionada en pantalla indicando si es o no parte del fin de semana. Preguntar además si desea continuar, en caso afirmativo volver al principio.
using System;

namespace TrabajoPractico_2
{
    public class Ejercicio2
    {
        public static void Resolver()
        {
            //Variable para la respuesta del usuario
                string respuesta;
            //  *Repetir el proceso
            do
            {
                // Solicitar un dia de la semana
                Console.WriteLine("Ingresar día de la semana: ");
                // Guardar el dia ingresado
                string dia = Console.ReadLine().ToLower();

                // Evaluar el dia ingresado por el usuario
                switch (dia)
                {
                    case "sabado":
                    case "domingo":
                        // Mostrar el mensaje si es sabado o domingo
                        Console.WriteLine("{0} Es parte del fin de semana :)", dia);
                        break;
                    default:
                        // Mostrar el mensaje si no es fin de semana
                        Console.WriteLine("{0} No es parte del fin de semana :(", dia);
                        break;
                }

                // preguntar al usuario si desea continuar
                Console.WriteLine("¿Desea continuar? (S/N)");
                // leer la respuesta del usuario
                respuesta = Console.ReadLine();
                // *Mientras la respuesta sea 's'
            } while (respuesta.ToLower() == "s");
        }
    }
}

