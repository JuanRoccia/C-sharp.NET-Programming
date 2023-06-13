using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio3
{
    public class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre)
        {

        }
        // Método para xplicar
        public void Explicar()
        {
            Console.WriteLine("Estoy Explicando.");
        }
    }
}
