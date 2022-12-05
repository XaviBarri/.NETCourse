using System;

namespace AppConsola
{
    public partial class Persona
    {
        public virtual void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);

            MostrarDatosCompletos();
        }

        partial void MostrarDatosCompletos();

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
}