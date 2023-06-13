namespace TrabajoPractico3Ejercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del perro: ");
            string nombre = Console.ReadLine();

            Perro perro = new Perro();
            perro.SetNombre(nombre);

            Console.WriteLine(perro.GetNombre());
            perro.Comer();
        }
    }
}