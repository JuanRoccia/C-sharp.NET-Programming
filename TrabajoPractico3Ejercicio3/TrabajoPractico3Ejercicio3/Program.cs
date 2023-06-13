using System.Security.Cryptography.X509Certificates;

namespace TrabajoPractico3Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de tipo Persona
            Persona[] personas = new Persona[3];

            // Solicitar al usuario los nombres de tres personas y almacenarlos en el arreglo
            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write("Ingresa el nombre " + (i+1) + ": ");
                string nombre = Console.ReadLine();

                Console.Write("¿Es " + nombre + " un estudiante o un profesor? (E/P): ");
                string tipo = Console.ReadLine().ToUpper();

                if (tipo == "E") // Si el usuario ingresó "E", crear un Estudiante
                {
                    personas[i] = new Estudiante(nombre);
                }
                else if (tipo == "P") // Si el usuario ingresó "P", crear un Profesor
                {
                    personas[i] = new Profesor(nombre);
                }
                else
                {
                    Console.WriteLine("Tipo no reconocido. Creando una Persona genérica.");
                    personas[i] = new Persona(nombre);
                }
            }


            //Persona persona = new Persona("Juan");

            // Leer las personas en el arreglo y ejecutar los métodos
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.ToString());

                // Si la persona es un Estudiante, ejecutar el método Estudiar
                if (persona is Estudiante estudiante)
                {
                    estudiante.Estudiar();
                }
                // Si la persona es un Profesor, ejecutar el método Explicar
                else if (persona is Profesor profesor)
                {
                    profesor.Explicar();
                }
            }


        }
    }
}