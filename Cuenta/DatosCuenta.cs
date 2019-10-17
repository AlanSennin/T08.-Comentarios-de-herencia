using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class DatosCuenta
    {
        public List<Pensiones> MetodoPensiones() //Lista heredada de la clase "Pensiones" que a su vez esta heredada de la clase "Cuenta"
        {
            List<Pensiones> Lista = new List<Pensiones>(); //Instanciando la lista de pensiones como "Lista"
            Lista.Add(new Pensiones { Numero = 100, Saldo = 1000, Vencimiento = Convert.ToDateTime("11/05/2021"), Titular = "Alan Garcia", Interes = 2.21, NumCuentaOrigen = 19210494, Cotizacion = 50 });
            Lista.Add(new Pensiones { Numero = 200, Saldo = 2000, Vencimiento = Convert.ToDateTime("11/05/2022"), Titular = "Brandon Garcia", Interes = 2.21, NumCuentaOrigen = 19210495, Cotizacion = 50 });
            Lista.Add(new Pensiones { Numero = 300, Saldo = 3000, Vencimiento = Convert.ToDateTime("11/05/2025"), Titular = "Humberto Garcia", Interes = 2.21, NumCuentaOrigen = 19210496, Cotizacion = 50 });
            Lista.Add(new Pensiones { Numero = 400, Saldo = 4000, Vencimiento = Convert.ToDateTime("11/05/2024"), Titular = "Mario Garcia", Interes = 2.21, NumCuentaOrigen = 19210497, Cotizacion = 50 });
            Lista.Add(new Pensiones { Numero = 500, Saldo = 5000, Vencimiento = Convert.ToDateTime("11/05/2025"), Titular = "Isaias Garcia", Interes = 2.21, NumCuentaOrigen = 19210498, Cotizacion = 50 });
            return Lista;
        }

        public List<CuentaAhorro> Ahorro() //Instanciando la lista de Cuenta de Ahorro como "Lista"
        {
            List<CuentaAhorro> Lista = new List<CuentaAhorro>();
            Lista.Add(new CuentaAhorro { Numero = 100, Saldo = 1000, Vencimiento = Convert.ToDateTime("11/05/2021"), Titular = "Alan Garcia", Interes = 2.21 });
            Lista.Add(new CuentaAhorro { Numero = 200, Saldo = 2000, Vencimiento = Convert.ToDateTime("11/05/2022"), Titular = "Brandon Garcia", Interes = 2.21 });
            Lista.Add(new CuentaAhorro { Numero = 300, Saldo = 3000, Vencimiento = Convert.ToDateTime("11/05/2025"), Titular = "Humberto Garcia", Interes = 2.2 });
            Lista.Add(new CuentaAhorro { Numero = 400, Saldo = 4000, Vencimiento = Convert.ToDateTime("11/05/2024"), Titular = "Mario Garcia", Interes = 2.21 });
            Lista.Add(new CuentaAhorro { Numero = 500, Saldo = 5000, Vencimiento = Convert.ToDateTime("11/05/2025"), Titular = "Isaias Garcia", Interes = 2.21 });
            return Lista;
        } 

        public List<CuentaCorriente> Corriente() //Instanciano la lista de Cuenta Correinte como "Corriente"
        {
            List<CuentaCorriente> Corriente = new List<CuentaCorriente>();
            Corriente.Add(new CuentaCorriente { Numero = 100, Saldo = 1000, Titular = "Alan Garcia", Interes = 2.21 });
            Corriente.Add(new CuentaCorriente { Numero = 200, Saldo = 2000, Titular = "Brandon Garcia", Interes = 2.21 });
            Corriente.Add(new CuentaCorriente { Numero = 300, Saldo = 3000, Titular = "Humberto Garcia", Interes = 2.2 });
            Corriente.Add(new CuentaCorriente { Numero = 400, Saldo = 4000, Titular = "Mario Garcia", Interes = 2.21 });
            Corriente.Add(new CuentaCorriente { Numero = 500, Saldo = 5000, Titular = "Isaias Garcia", Interes = 2.21 });
            return Corriente;
        }

    }
}
