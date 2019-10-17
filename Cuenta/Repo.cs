using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Repo
    {
        DatosCuenta ad; //Instanciando globalmente "DatosCuenta" como "ad"

        public Repo() //Constructor para convertir en instancia el objeto de arriba
        {
            ad = new DatosCuenta(); //Instanciando la clase "DatosCuenta" como ad
        }

        internal void Principal() //Clase Principal al correr el programa
        {
            Console.WriteLine("¡Bienvenidos al Banco!");
            Console.WriteLine(" ");
            Menu(); //Mando a llamar el Metodo "Menu"...

            Console.ReadLine();
        }

        private void Menu()
        {
            //Menu para seleccionar la ocion que desee
            Console.WriteLine("Seleccione una Opcion...");
            Console.WriteLine(" ");
            Console.WriteLine("(1) Cuenta Ahorro");
            Console.WriteLine("(2) Pensiones");
            Console.WriteLine("(3) Cuenta Corriente");

            //Switch para mandar a llamar los metodos necesarios
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("¡Bienvenidos a mi Cuenta Ahorro!");
                    ObtenerDatosAhorro(); //Mando a llamar el metodo "ObetenerDatosAhorro"...
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("¡Bienvenido a las Pensiones!");
                    ObtenerDatosPensiones(); //Mando a llamar el metoodo "ObtenerDatosPensiones"...
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("¡Bienvenido a Cuenta Corriente!");
                    ObtenerDatosCorriente(); //Mando a llamar el metodo "ObtenerDatosCorriente"...
                    break;

                default:
                    break;
            }
        }

        private void ObtenerDatosCorriente() //Metodo para obtener los datos de Cuenta Corriente...
        {
            int Numero = ObtenerDatos(); //Asignar a "Numero" el metodo "ObtenerDatos"
            var Lista = ad.Corriente();

            CuentaCorriente C = new CuentaCorriente();

            foreach (var Cuenta in Lista)
            {
                if (Numero == Cuenta.Numero) //Condicion si el Numero que introducimos es el mismo a "Numero" de la clase "Cuenta"
                {
                    C = Cuenta; //Asignando a "P"
                }
            }

            MenuUsuario(C); //Mando a llamar el menu del metodo "MenuUsuario"...
        }

        private void ObtenerDatosPensiones() //Metodo para obtener los datos de las Pensiones...
        {
            int Numero = ObtenerDatos(); //Asignar a "Numero" el metodo "ObtenerDatos"
            var Lista = ad.MetodoPensiones(); //Asignar a "Lista" la lista de "MetodosPensiones" instanciada de la clase "DatosCuenta"

            Pensiones P = new Pensiones(); //Instanciando la clase Pensiones

            //foreach para cada variable de la lista sacar el item que necesitamos hasta que acabe
            foreach (var Cuenta in Lista) 
            {
                if (Numero == Cuenta.Numero) //Condicion si el Numero que introducimos es el mismo a "Numero" de la clase "Cuenta"
                {
                    P = Cuenta; //Asignando a "P"
                }
            }

            MenuUsuario(P); //Mando a llamar el menu del metodo "MenuUsuario"...
        }

        private void MenuUsuario(Cuenta P) //Menu del Usuario
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenido a tu Cuenta! : "+P.Titular);
            Console.WriteLine("Seleccione una Opcion...");
            Console.WriteLine(" ");
            Console.WriteLine("(1) Consultar Saldo");
            Console.WriteLine("(2) Transferir Saldo");
            Console.WriteLine("(3) Intereses por Mes");
            Console.WriteLine("(4) Ingreso...");

            //Switch para seleccionar la opcion deseada
            switch (Console.ReadLine())
            {
                case "1":
                    P.ConsultarSaldo(P); //Mando a llamar el metodo para consultar saldo de la clase "Cuenta"
                    break;

                case "2":
                    P.Transferir(P); //Mando a llamar el metodo para transferir saldo de la clase "Cuenta"
                    break;

                case "3":
                    P.InteresesXMes(P);
                    Console.WriteLine();
                    break;

                case "4":
                    P.Ingreso(); //Mando a llamar el metodo para ingresar mi usuario de la clase "Cuenta"
                    break;

                default:
                    break;
            }

        }

        private void ObtenerDatosAhorro() //Metoedo para obtener los datos ahorrados
        {
            int Numero = ObtenerDatos(); //Asignando a "Numero" el metodo "ObtenerDatos"
            var Lista = ad.Ahorro();

            CuentaAhorro R = new CuentaAhorro();

            foreach (var Cuenta in Lista)
            {
                if (Numero == Cuenta.Numero) 
                {
                    R = Cuenta; 
                }
            }

            MenuUsuario(R);
        }

        private int ObtenerDatos() //Metodo ´para obtener datos usado en todo lo de arriba...
        {
            Console.WriteLine("Ingrese su Numero de Cuenta:");
            string Res = Console.ReadLine(); //Asignar a "Res" lo que introdujamos
            return Convert.ToInt32(Res); //Devolver el valor convertido en Int32
        }
    }
}
