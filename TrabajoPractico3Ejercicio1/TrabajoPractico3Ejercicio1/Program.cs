namespace TrabajoPractico3Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Este bloque de código es para las primeras pruebas del programa.
             * 1. Crea un objeto Auto con 10 de combustible.
             * 2. Conduce el auto, lo que debería reducir el combustible.
             * 3. Carga 5 de combustible en el auto.
             * 4. Conduce el auto de nuevo.
             * 5. Imprime la representación en cadena del objeto Auto.
             */
            Auto miAuto = new Auto(10);
            miAuto.Conducir();
            miAuto.Cargar(5);
            miAuto.Conducir();
            Console.WriteLine(miAuto.ToString());

            /* Ahora si, esta parte del código es para testear el programa
             * con las consignas del trabajo practico 3, ejercicio1.
             */

            // Crear un Auto con 0 de combustible
            Auto auto1 = new Auto(0);

            // Solicitar cantidad de combustible al usuario
            Console.Write("Ingrese la cantidad de combustible para cargar: ");
            string entrada = Console.ReadLine();
            int cantidadCombustible;
            if (int.TryParse(entrada, out cantidadCombustible))
            {
                // Si la entrada es un número entero, cargar esa cantidad de combustible
                auto1.Cargar(cantidadCombustible);
            }
            else
            {
                // Si la entrada no es un número entero, mostrar un mensaje de error
                Console.WriteLine("La entrada no es un número entero válido.");
            }

            // Conducir el auto
            auto1.Conducir();

        }

    }
}