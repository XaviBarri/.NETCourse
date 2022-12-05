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
            ColeccionAlumnos lista =new ColeccionAlumnos();

            lista.Add(new Alumno() { Nombre = "Rubén", Apellidos = "Rubio"});
            lista.Insert(0, new Alumno() { Nombre = "Manolo", Apellidos = "Fernández"});

            foreach(Alumno elemento in lista)
            {
                Console.WriteLine($"Alumno: {elemento.Nombre} {elemento.Apellidos}");
            }

            //lista.Remove(new Alumno() { Nombre = "Rubén", Apellidos = "Rubio"});

            Console.WriteLine($"Alumno en posición 1 {lista[1].Nombre} {lista[1].Apellidos}"); 

            Console.ReadLine();
        }
    }

    public class ColeccionAlumnos : System.Collections.CollectionBase
    {
        public int Add(Alumno value)
        {
            return List.Add(value);
        }

        public void Insert(int index, Alumno value)
        {
            List.Insert(index,value);
        }

        public void Remove(Alumno alumno)
        {
            List.Remove(alumno);
        }

        public void Sort()
        {
            InnerList.Sort();
        }

        public Alumno this[int index]
        {
            get
            {
                return (Alumno)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}