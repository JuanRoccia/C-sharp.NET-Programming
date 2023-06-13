using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio5
{
    public class Perro : Animal
    {
        // Método Comer
        public override void Comer()
        {
            Console.WriteLine("El perro " + GetNombre() + " está comiendo");
        }
    }
}
