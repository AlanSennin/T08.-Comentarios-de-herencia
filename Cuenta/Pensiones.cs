using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Pensiones: Cuenta //Heredando de la clase "Cuenta"
    {
        //Encapsulando los atributos a usar en las listas
        public DateTime Vencimiento { get; set; }
        public double Cotizacion { get; set; }
        public int NumCuentaOrigen { get; set; }
    }
}
