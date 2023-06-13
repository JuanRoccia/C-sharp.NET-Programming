using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio5
{
    public abstract class Animal
    {
        // Propiedad Nombre
        public string Nombre { get; set; }

        // Método SetNombre
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        // Método GetNombre
        public string GetNombre()
        {
            return Nombre;
        }

        // Método Comer (abstracto)
        public abstract void Comer();
    }
}
