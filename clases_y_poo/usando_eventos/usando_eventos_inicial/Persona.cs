using System;
using System.Xml.Serialization;

namespace AppConsola
{
    public class Persona
    {
        private DateTime fechaNacimiento;

        public static int NumeroCreacionesEstatica { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento
        {
            set
            {
                if (value > DateTime.Today)
                {
                    fechaNacimiento = value;
                }
            }
        }

        public int Edad
        {
            get
            {
                return (int)(DateTime.Today.Subtract(fechaNacimiento).Days / 365.25);
            }
        }

        public virtual void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }
}