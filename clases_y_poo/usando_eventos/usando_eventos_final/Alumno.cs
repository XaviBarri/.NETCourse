using System;

namespace AppConsola
{
    public class Alumno : Persona
    {
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }

        public override void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }
}