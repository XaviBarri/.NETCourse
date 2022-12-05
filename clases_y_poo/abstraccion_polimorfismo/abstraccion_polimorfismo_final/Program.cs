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
            //Persona persona = new Persona("Rubén", "Rubio", new DateTime(1950, 3, 25));
            //persona.MostrarNombre();

            Alumno alumno = new Alumno();
            alumno.Nombre = "Alumno 1";
            alumno.Apellidos = "apellidos";
            alumno.MostrarNombre();

            Profesor profesor = new Profesor();
            profesor.Nombre = "Profesor 1";
            profesor.Apellidos = "apellidos";
            profesor.MostrarNombre();
            
            Director director = new Director();
            director.Nombre = "Rubén";
            director.Apellidos = "Rodríguez";
            director.MostrarNombre();

            Console.ReadLine();
        }
    }

    abstract class Persona
    {
        private DateTime FechaNacimiento;

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public virtual int Edad
        {
            get
            {
                return (int)(DateTime.Today.Subtract(FechaNacimiento).Days / 365.25);
            }
        }

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

        public abstract bool ValidarInformacion();

        public virtual void MostrarNombre()
        {
            if(ValidarInformacion())
                Console.WriteLine("El nombre es " + Nombre + " " + Apellidos + " - Edad " + Edad.ToString());
            else
                Console.WriteLine("Faltan datos");
        }
    }

    class Profesor : Persona
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }
        public override int Edad
        {
            get
            {
                return -1;
            }
        }

        public override bool ValidarInformacion()
        {
            return true;
        }

        public override void MostrarNombre()
        {
            Console.WriteLine("El nombre del profesor es " + Nombre + " " + Apellidos);
            //base.MostrarNombre();
        }
    }

    class Alumno : Persona
    {
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }

        public override bool ValidarInformacion()
        {
            return true;
        }
    }

    class Director : Profesor
    {
        public override void MostrarNombre()
        {
            Console.WriteLine("El director es " + Nombre + " " + Apellidos);
        }
    }
}