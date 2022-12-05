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
            Persona persona = new Persona("Rubén", "Rubio", new DateTime(1950, 3, 25));
            persona.MostrarNombre();

            persona.Apellidos = "Rubio";
            persona.Nombre = "Rubén";

            persona.MostrarNombre();

            Alumno alumno1 = new Alumno();
            Profesor profesor1 = new Profesor();

            Console.ReadLine();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona()
        {
            Nombre = "Sin nombre";
            Apellidos = "Sin apellidos";
            FechaNacimiento = DateTime.Today;
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        ~Persona()
        {
            Console.WriteLine("Clase finalizada");
        }

        public Persona(string nombre, string apellidos, DateTime fechaNacimiento)
            : this(nombre, apellidos)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos + " - F. nac. " + FechaNacimiento.ToString());
        }
    }

    class Profesor : Persona
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }
    }

    class Alumno : Persona
    {
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }
        public int Edad { get; set; }
    }
}