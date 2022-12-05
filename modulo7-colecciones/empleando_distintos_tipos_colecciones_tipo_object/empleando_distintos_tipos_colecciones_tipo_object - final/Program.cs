using System.Reflection.PortableExecutable;
using System.Collections;
using System;
using System.Text;

namespace AppConsola
{
    class Program
    {
        static void Main()
        {
            /*
            ArrayList lista = new ArrayList()
            {
                "Elemento 1",
                "Elemento 2",
                "Elemento 3"
            };
            
            lista.Add("Elemento 4");

            lista.Insert(2,"Elemento 5");

            foreach(Object elemento in lista)
            {
                string texto = (string)elemento;

                Console.WriteLine(texto);
            }

            Console.WriteLine("Tras eliminar un elemento");
            lista.RemoveAt(3);
            foreach(Object elemento in lista)
            {
                string texto = (string)elemento;

                Console.WriteLine(texto);
            }
            */

            /*
            Hashtable tabla = new Hashtable();

            tabla.Add("REF001","Rubén Rubio");
            tabla.Add("REF002","Fernando Pérez");
            tabla.Add("REF003","Manuel Alarcón");

            foreach(DictionaryEntry elemento in tabla)
            {
                Console.WriteLine($"{elemento.Key} => {elemento.Value}");
            }

            Console.WriteLine("Mostrando las claves");
            foreach(var clave in tabla.Keys)
            {
                Console.WriteLine($"Clave: {clave}");
            }

            Console.WriteLine("Mostrando los valores");
            foreach(var valor in tabla.Values)
            {
                Console.WriteLine($"Valor: {valor}");
            }

            Console.WriteLine($"Existe la clave REF002: {tabla.ContainsKey("REF002")}");
            Console.WriteLine($"Existe la clave REF005: {tabla.ContainsKey("REF005")}");
            Console.WriteLine($"Existe el valor Manuel Alarcón: {tabla.ContainsValue("Manuel Alarcón")}");

            Console.WriteLine($"Valor de la clave REF003: {tabla["REF003"]}");

            tabla["REF003"] = "Pepito Pérez";

            Console.WriteLine($"Nuevo valor de la clave REF003: {tabla["REF003"]}");
            */

            Queue cola = new Queue();
            Stack pila = new Stack();

            for(int i = 0; i< 10; i++)
            {
                cola.Enqueue(i);
                pila.Push(i);
            }

            Console.WriteLine("Obteniendo elementos de la cola");
            while(cola.Count > 0)
            {
                Console.WriteLine(cola.Dequeue());
            }

            Console.WriteLine("Obteniendo elementos de la pila");
            while(pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());
            }

            Console.ReadLine();
        }
    }
}