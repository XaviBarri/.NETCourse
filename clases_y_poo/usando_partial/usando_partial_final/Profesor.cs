using System;

namespace AppConsola
{
    public class Profesor : Persona
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }

        public sealed override void MostrarNombre()
        {
            base.MostrarNombre();

            Console.WriteLine("Llamada des de MostrarNombre - Profesor");
        }
    }

    public class JefeEstudios : Profesor
    {

    }
}