using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3Ejercicio1;

namespace TrabajoPractico3Ejercicio1
{
    public class Auto : IVehiculo
    {
        private int combustible;

        // Constructor de la clase Auto
        public Auto(int combustibleInicial)
        {
            combustible = combustibleInicial;
        }

        public void Conducir()
        {
            if (combustible > 0)
            {
                combustible--;
                Console.WriteLine("El auto está conduciendo. Combustible restante: " + combustible);
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para conducir.");
            }

        }

        public bool Cargar(int cantidadCombustible)
        {
            if (cantidadCombustible > 0)
            {
                combustible += cantidadCombustible;
                Console.WriteLine("Se cargó combustible. Combustible actual: " + combustible);
                return true;
            }
            else
            {
                Console.WriteLine("La cantidad de combustible a cargar debe ser mayor a 0.");
                return false;
            }
        }

    }
}