using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio3
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre)
        {

        }
        // Método para estudiar
        public void Estudiar()
        {
            Console.WriteLine("Estoy Estudiando.");
        }

        // Método para ver la edad
        public void VerEdad()
        {
            Console.WriteLine("Mi edad es: " + GetEdad() + " años.");
        }
    }
}
