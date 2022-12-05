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
            persona.Nombre = "Rubén";
            persona.Apellidos = "Rubio";
            persona.FechaNacimiento = new DateTime(1977, 5, 24);
            persona.MostrarNombre();

            Console.ReadLine();
        }
    }
}