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

            Animal animal = new Animal();
            animal.EstablecerEspecie("perro");
            animal.MostrarDatos();
            //animal.SegundoMetodo();

            Console.ReadLine();
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }

    class Animal
    {
        protected string subespecie = "Variable nivel clase";
        internal string Nombre { get; set; }
        public string Especie { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine("Especie: "+Especie);
            Console.WriteLine("subespecie: "+subespecie);
        }

        public void SegundoMetodo()
        {
            string subespecie = "variable nivel metodo";
            string Nombre = "nombre interno";
            Console.WriteLine(subespecie);
            Console.WriteLine(Nombre);
        }

        public void EstablecerEspecie(string nuevaEspecie)
        {
            Especie = DefinirEspecie();
            subespecie = DefinirEspecie();

            string DefinirEspecie()
            {
                if (nuevaEspecie == "perro")
                    return "Dog";
                else if (nuevaEspecie == "gato")
                    return "Cat";
                else
                    return "Desconocido";
            }
        }
    }
}