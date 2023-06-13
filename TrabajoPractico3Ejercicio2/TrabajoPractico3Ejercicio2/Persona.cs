using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio2
{
    public class Persona
    {
        // Campo para almacenar la edad
        private int edad;

        // Método para saludar
        public void Saludar()
        {
            Console.WriteLine("¡Hola! Soy una persona.");
        }

        // Método para establecer la edad
        public void SetEdad(int nuevaEdad)
        {
            edad = nuevaEdad;
        }

        // Método para obtener la edad
        public int GetEdad()
        {
            return edad;
        }
    }
}
