using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio1
{
    public interface IVehiculo
    {
        void Conducir();
        bool Cargar(int cantidadCombustible);
    }
}