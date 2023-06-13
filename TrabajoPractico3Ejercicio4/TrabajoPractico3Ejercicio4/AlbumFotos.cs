using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio4
{
    public class AlbumFotos
    {
        protected int numPaginas;

        // Método GetNumPaginas
        public int GetNumPaginas() { return numPaginas; }

        // Constructor predeterminado
        public AlbumFotos() { numPaginas = 16; }

        // Constructor adicional
        public AlbumFotos(int numPaginas) { this.numPaginas = numPaginas; }
    }
}
