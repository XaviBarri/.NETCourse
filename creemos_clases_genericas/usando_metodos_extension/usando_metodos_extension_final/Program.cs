using System;
using System.Text;

namespace AppConsola
{
    class Program
    {
        static void Main()
        {
            string texto = "quiero la primera letra de cada palabra en mayúscula";

            Console.WriteLine(texto.ConvertirAMayuscula());

            Console.WriteLine("texto de prueba".ConvertirAMayuscula());

            Alumno alumno = new Alumno();
            alumno.Nombre = "Rubén";
            alumno.Apellidos = "Rubio";
            alumno.MostrarNombre();
            Console.WriteLine(alumno.MostrarApellido());

            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        public static string ConvertirAMayuscula(this string data)
        {
            string[] elementos = data.Split(' ');
            
            StringBuilder sb = new StringBuilder();
            foreach(var palabra in elementos)
            {
                sb.Append($"{palabra.Substring(0,1).ToUpper()}{palabra.Substring(1).ToLower()} ");
            }

            return sb.ToString();
        }

        public static string MostrarApellido(this IContribuyente alumno)
        {
            return $"El apellido es {alumno.Apellidos}";
        }
    }
}