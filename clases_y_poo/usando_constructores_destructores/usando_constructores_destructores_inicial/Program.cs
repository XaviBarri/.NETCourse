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
            persona.Apellidos = "Rubio";
            persona.Nombre = "Rubén";

            persona.MostrarNombre();

            Console.ReadLine();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }
}