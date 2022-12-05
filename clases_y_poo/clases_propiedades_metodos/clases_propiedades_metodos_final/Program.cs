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
            persona.Apellidos ="Rubio";
            
            persona.MostrarInfo();

            string nuevoNombre = "Felipe";
            string nuevoApellido = "Rodríguez";
            int tamano=0;

            string valorDevuelto = persona.CambiarNombre(ref nuevoNombre, nuevoApellido, out tamano);
            Console.WriteLine(valorDevuelto);

            Console.WriteLine("Valor de nuevoNombre tras modificar en la función " + nuevoNombre);
            Console.WriteLine("Tamaño del texto devuelto " + tamano.ToString());
            
            persona.CambiarNombre("Rubén");
            persona.MostrarInfo();

            Console.ReadLine();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine("Datos de la persona: " + Nombre + " " + Apellidos);
        }

        public void CambiarNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string CambiarNombre(ref string nombre, string apellidos, out int tamano)
        {
            Nombre = nombre;
            Apellidos = apellidos;

            nombre = "Valor cambiado";
            
            string valorDevolver = "Datos de la persona: " + Nombre + " " + Apellidos;
            tamano = valorDevolver.Length;
            return valorDevolver;
        }
    }
}