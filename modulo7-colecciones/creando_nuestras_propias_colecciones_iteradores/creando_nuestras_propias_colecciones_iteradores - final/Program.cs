using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AppConsola
{
    class Program
    {
        static void Main()
        {
            var matriz = new Conserje[5]
            {
                new Conserje() { Nombre = "Conserje 1" },
                new Conserje() { Nombre = "Conserje 2" },
                new Conserje() { Nombre = "Conserje 3" },
                new Conserje() { Nombre = "Conserje 4" },
                new Conserje() { Nombre = "Conserje 5" }
            };

            ColeccionConserje lista = new ColeccionConserje(matriz);
            foreach(var conserje in lista)
            {
                Console.WriteLine($"Conserje => {conserje.Nombre}");   
            }

            Console.WriteLine("Recorrido desde un método");
            foreach(var elemento in Iterador())
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();
        }

        private static IEnumerable<string> Iterador()
        {
            for(int i = 0; i < 10; i++)
            {
                yield return $"Pasada {i}";
            }
        }
    }

    public class ColeccionConserje : IEnumerable<Conserje>
    {
        private Conserje[] _conserjes;

        public ColeccionConserje(Conserje[] conserjes)
        {
            _conserjes = conserjes;
        }

        public IEnumerator<Conserje> GetEnumerator()
        {
            for(int i = 0; i< _conserjes.Length;i++)
            {
                yield return _conserjes[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}