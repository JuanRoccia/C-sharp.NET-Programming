using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio3
{
    public class Persona
    {   
        public string Nombre { get; set; }
        // Campo para almacenar la edad
        private int edad;

        // Constructor que recibe el nombre como parámetro
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        // Método para saludar
        public void Saludar()
        {
            Console.WriteLine("¡Hola! Soy " + Nombre);
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

        // Sobreescriba el método ToString()
        public override string ToString()
        {
            return Nombre;
        }
    }
}
