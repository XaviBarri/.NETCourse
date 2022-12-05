using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.OnChange += DatosCambiados;

            persona.Nombre = "Rubén";
            persona.Apellidos = "Rubio";
            persona.FechaNacimiento = new DateTime(1977, 5, 24);
            persona.MostrarNombre();

            persona.Nombre = "Felipe";

            Console.ReadLine();
        }

        public static void DatosCambiados(object sender, EventArgs args) //string campo, string valorAnterior, string valorNuevo)
        {
            var datosCambio = args as DemoEventArgs;
            Console.WriteLine("Datos cambiados. Campo: {0} - valor anterior: {1} - valor nuevo {2}",
                datosCambio.Campo, datosCambio.ValorAnterior, datosCambio.ValorNuevo);
        }
    }
}