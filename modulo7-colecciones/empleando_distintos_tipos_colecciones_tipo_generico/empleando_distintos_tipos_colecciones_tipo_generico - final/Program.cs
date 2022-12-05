using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsola
{
    class Program
    {
        static void Main()
        {
            /*
            List<string> lista = new List<string>()
            {
                "Elemento 1",
                "Elemento 2",
                "Elemento 3"
            };

            lista.Add("Elemento 4");
            lista.Insert(1, "Elemento 5");

            foreach(string elemento in lista)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Eliminación");
            lista.Remove("Elemento 3");

            foreach(string elemento in lista)
            {
                Console.WriteLine(elemento);
            }
*/
/*
            Dictionary<int, Alumno> tabla=new Dictionary<int, Alumno>();

            tabla.Add(101, new Alumno(){ Nombre = "Rubén", Referencia = 101});
            tabla.Add(103, new Alumno(){ Nombre = "Manolo", Referencia = 103});
            tabla.Add(102, new Alumno(){ Nombre = "Pepe", Referencia = 102});
            tabla.Add(105, new Alumno(){ Nombre = "Manuel", Referencia = 105});
            tabla.Add(104, new Alumno(){ Nombre = "Juan", Referencia = 104});

            foreach(var alumno in tabla)
            {
                Console.WriteLine($"Alumno ({alumno.Key}): {alumno.Value.Nombre}");
            }

            Console.WriteLine($"Alumno de la posición 103: {tabla[103].Nombre}");
            */

/*
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();

            for(int i = 0; i<10;i++)
            {
                cola.Enqueue(i);
                pila.Push(i);
            }

            Console.WriteLine("Pila");
            while(pila.Count>0)
            {
                Console.WriteLine(pila.Pop());
            }

            Console.WriteLine("Cola");
            while(cola.Count>0)
            {
                Console.WriteLine(cola.Dequeue());
            }
            */

            SortedList<int,Alumno> tabla = new SortedList<int,Alumno>();

            tabla.Add(101, new Alumno(){ Nombre = "Rubén", Referencia = 101});
            tabla.Add(103, new Alumno(){ Nombre = "Manolo", Referencia = 103});
            tabla.Add(102, new Alumno(){ Nombre = "Pepe", Referencia = 102});
            tabla.Add(105, new Alumno(){ Nombre = "Manuel", Referencia = 105});
            tabla.Add(104, new Alumno(){ Nombre = "Juan", Referencia = 104});

            foreach(var alumno in tabla)
            {
                Console.WriteLine($"Alumno ({alumno.Key}): {alumno.Value.Nombre}");
            }
            
            Console.ReadLine();
        }
    }
}