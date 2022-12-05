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
            Persona persona1 = new Persona();
            persona1.MostrarNombre();

            Persona persona2 = new Persona("Rubén","Rubio");
            persona2.MostrarNombre();

            Persona persona3 = new Persona("Fernando","Martín", new DateTime(1970,5,28));
            persona3.MostrarNombre();

            Console.ReadLine();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento {get;set;}

        public Persona()
        {
            Nombre = "Sin nombre";
            Apellidos= "Sin apellidos";
            FechaNacimiento = new DateTime(1900,1,1);
        }

        public Persona(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public Persona(string nombre, string apellidos, DateTime fechaNacimiento)
        :this(nombre,apellidos)
        {
            FechaNacimiento = fechaNacimiento;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos + " - "+FechaNacimiento.ToShortDateString());
        }

        ~Persona()
        {

        }
    }
}