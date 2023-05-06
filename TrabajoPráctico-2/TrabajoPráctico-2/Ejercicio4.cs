// Ejercicio 4: Realice un programa que muestre un menú con las operaciones de suma, resta, división y multiplicación de 2 números ingresados por el usuario, muestre el resultado en pantalla
using System;

namespace TrabajoPractico_2
{
    public class Ejercicio4
    {
        public static void Resolver()
        {
            // declaramos las variables
            int num1, num2;
            string operacion;

            // Solicitamos la operación
            Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
            operacion = Console.ReadLine();

            // Solicitamos los números
            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());

            // Evaluamos que operacion debe realizar y ejecutamos
            switch (operacion)
            {
                case "+":
                    Console.WriteLine("Resultado: {0}", num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("Resultado: {0}", num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("Resultado: {0}", num1 * num2);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Resultado: {0}", (float)num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación inválida.");
                    break;
            }
        }
    }
}
