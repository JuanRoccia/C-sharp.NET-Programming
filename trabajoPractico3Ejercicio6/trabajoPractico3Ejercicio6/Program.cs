namespace trabajoPractico3Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// Crear una nueva cuenta bancaria
            CuentaBancaria cuenta = new CuentaBancaria("Juan", 0.05, 1000M);

            // Imprimir el balance inicial
            Console.WriteLine(cuenta.ToString());

            // Depositar dinero en la cuenta
            cuenta.Deposito(500M);
            Console.WriteLine(cuenta.ToString());

            // Retirar dinero de la cuenta
            cuenta.Retiro(200M);
            Console.WriteLine(cuenta.ToString());

            // Retirar una cantidad mayor al balance de la cuenta principal
            try
            {
                cuenta.Retiro(2000M);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al intentar retirar dinero: " + ex.Message);
            }

            Console.WriteLine(cuenta.ToString());

            /*En este código, primero creamos una nueva cuenta 
             * bancaria con un balance inicial de 1000. Luego, 
             * depositamos 500 en la cuenta y retiramos 200. 
             * Finalmente, intentamos retirar 2000, que es más 
             * de lo que tenemos en la cuenta principal. Como 
             * hemos implementado la lógica para retirar de la 
             * cuenta de respaldo cuando no hay suficiente saldo 
             * en la cuenta principal, este retiro debería ser 
             * exitoso y el balance de la cuenta de respaldo 
             * debería disminuir.*/
        }
    }
}