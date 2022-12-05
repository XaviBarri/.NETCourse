using System;

namespace AppConsola
{
    public partial class Persona
    {
        private DateTime fechaNacimiento;

        public static int NumeroCreacionesEstatica { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        partial void MostrarDatosCompletos()
        {
            Console.WriteLine ("Llamada desde método parcial");
        }
    }
}