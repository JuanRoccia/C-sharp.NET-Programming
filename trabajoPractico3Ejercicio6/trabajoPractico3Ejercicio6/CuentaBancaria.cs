using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico3Ejercicio6
{
    /* 
     * En este código, he agregado un nuevo campo cuentaRespaldo 
     * a la clase CuentaBancaria y lo he inicializado en el 
     * constructor. Luego, he modificado el método Retiro para 
     * que retire el dinero de la cuenta de respaldo si no hay 
     * suficiente saldo en la cuenta principal.
     */
    public class CuentaBancaria
    {
        private double tasaInteres;
        private string propietario;
        private decimal balance;
        private CuentaBancaria cuentaRespaldo; // Nueva cuenta de respaldo

        public CuentaBancaria(string propietario)
            : this(propietario, 0.0, 0.0M)
        {
        }

        public CuentaBancaria(string propietario, double tasaInteres)
            : this(propietario, tasaInteres, 0.0M)
        {
        }

        public CuentaBancaria(string propietario, double tasaInteres, decimal balance)
        {
            this.tasaInteres = tasaInteres;
            this.propietario = propietario;
            this.balance = balance;
            this.cuentaRespaldo = null; // Inicializar la cuenta de respaldo a null
        }


        public decimal Balance()
        {
            return balance;
        }

        public void Retiro(decimal monto)
        {
            if (balance >= monto)
            {
                balance -= monto;
            }
            else if (cuentaRespaldo != null && cuentaRespaldo.Balance() >= monto)
            {
                cuentaRespaldo.Retiro(monto);
            }
            else
            {
                // Crear una nueva cuenta de respaldo si es necesario
                if (cuentaRespaldo == null)
                {
                    cuentaRespaldo = new CuentaBancaria(propietario, tasaInteres, 0);
                }

                // Verificar si hay suficiente saldo en la cuenta de respaldo
                if (cuentaRespaldo.Balance() >= monto)
                {
                    // Retirar el dinero de la cuenta de respaldo
                    cuentaRespaldo.Retiro(monto);
                }
                else
                {
                    // Lanzar una excepción o simplemente no realizar el retiro
                    throw new Exception("No hay suficiente saldo en la cuenta principal y la cuenta de respaldo para cubrir el monto del retiro.");
                }
            }
        }

        public void Deposito(decimal monto)
        {
            balance += monto;
        }

        public void AddInteres()
        {
            balance = balance + balance * (decimal)tasaInteres;
        }

        public override string ToString()
        {
            return "La cuenta bancaria de " + propietario + " tiene un total de $ " + balance;
        }
    }
}
/* 
 * En cuanto a la pregunta sobre si es posible modificar el 
 * estado privado de una cuenta bancaria desde otra, la 
 * respuesta es no. Los campos privados de una clase solo 
 * pueden ser accedidos desde dentro de la misma clase. Sin 
 * embargo, puedes proporcionar métodos públicos en la clase 
 * que permitan a otras clases interactuar con estos campos 
 * privados de una manera controlada, como hemos hecho con los 
 * métodos Retiro, Deposito y Balance.
 */
