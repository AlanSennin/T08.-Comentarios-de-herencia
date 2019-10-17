using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class CuentaAhorro: Cuenta //Heredando de la clase "Cuenta"
    {
        public DateTime Vencimiento { get; set; } //Encapsulando el Vencimiento como "DateTime"
        
        public double IngresoXMes() //Metodo para saber el ingreso por mes
        {
            return 0;
        }
    }
}
