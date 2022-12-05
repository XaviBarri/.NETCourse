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

    class Persona
    {
        private DateTime fechaNacimiento;

        public static int NumeroCreacionesEstatica { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public virtual void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }

        public static void MostrarValorEstatico()
        {
            Console.WriteLine("Valor de NumeroCreacionesEstatica " + NumeroCreacionesEstatica);
        }
        public Persona()
        {
            NumeroCreacionesEstatica++;
        }

        static Persona()
        {
            NumeroCreacionesEstatica = 1000;
        }
    }

    class Profesor : Persona
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }

        public sealed override void MostrarNombre()
        {
            base.MostrarNombre();

            Console.WriteLine("Llamada des de MostrarNombre - Profesor");
        }
    }

    class JefeEstudios : Profesor
    {

    }

    class Alumno : Persona
    {
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }

        public override void MostrarNombre()
        {
            base.MostrarNombre();

            Console.WriteLine("Llamada des de MostrarNombre - Alumno");
        }
    }
}