using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Cuenta
    {
        //Encapsulando atributos principales
        public int Numero { get; set; }
        public string  Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }

        public bool Ingreso() //Metodo para Ingresar a tu cuenta
        {
            return false;
        }

        public double InteresesXMes(Cuenta P) //Meotodo para saber los intereses por mes
        {
            var Total = Interes + .16; //Asignarle a "Total" los intereses multiplicados por 0.16

            return (P.Interes) + (Convert.ToDouble(P.Saldo));
        }

        public void ConsultarSaldo(Cuenta Cuenta) //Metodo para consultar el saldo
        {
            Repo R = new Repo();
            Console.Clear();
            Console.WriteLine("Saldo Actual: $"+Cuenta.Saldo); //Imrimir el saldo concatenando "Saldo" de la clase "DatosCuenta"
            
        }

        public void Transferir(Cuenta Cuenta) //Metodo para transferir saldo
        {

        }
    }
}
