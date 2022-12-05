using System;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Persona persona = new Persona();
                Console.WriteLine("Contador: " + persona.Contador.ToString());
                Console.WriteLine("Contador estático: " + Persona.ContadorEstatico.ToString());
            }

            //persona.Nombre = "Rubén";
            //persona.Apellidos = "Rubio";
            //persona.MostrarNombre();

            string texto = Persona.ObtenerTexto();
            Console.WriteLine(texto);

            Console.WriteLine(Funciones.ObtenerTexto());

            Console.ReadLine();
        }
    }

    class Persona
    {
        public int Contador { get; set; }
        public static int ContadorEstatico { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        static Persona()
        {
            ContadorEstatico = 1000;
        }

        public Persona()
        {
            Contador++;
            ContadorEstatico++;
        }

        public virtual void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }

        public static string ObtenerTexto()
        {
            return "TExto desde método estático";
        }
    }

    static class Funciones
    {
        public static string ObtenerTexto()
        {
            return "TExto desde método y clase estáticos";
        }
    }
}