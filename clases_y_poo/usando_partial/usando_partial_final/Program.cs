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
            for (int i = 0; i < 10; i++)
            {
                Persona persona = new Persona();
                persona.Nombre = "Rubén";
                persona.Apellidos = "Rubio";
                persona.MostrarNombre();

                Persona.MostrarValorEstatico();
            }

            Console.ReadLine();
        }
    }
}