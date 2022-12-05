using System;

namespace AppConsola
{
    public class Alumno : Persona
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