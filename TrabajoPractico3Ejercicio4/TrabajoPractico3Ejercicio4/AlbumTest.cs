using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio4
{
    public class AlbumTest
    {
        static void Main(string[] args)
        {
            // Crear un álbum predeterminado y mostrar el número de páginas
            AlbumFotos album1 = new AlbumFotos();
            Console.WriteLine("Número de páginas del álbum predeterminado: " +  album1.GetNumPaginas());

            // Crear un álbum de 24 páginas y mostrar el número de páginas en pantalla.
            AlbumFotos album2 = new AlbumFotos(24);
            Console.WriteLine("Número de páginas del álbum creado: " + album2.GetNumPaginas());

            // Crear un super álbum y mostrar el número de páginas en pantalla.
            AlbumFotos album3 = new SuperAlbumFotos();
            Console.WriteLine("Número de páginas del super álbum: " + album3.GetNumPaginas());
        }
    }
}
