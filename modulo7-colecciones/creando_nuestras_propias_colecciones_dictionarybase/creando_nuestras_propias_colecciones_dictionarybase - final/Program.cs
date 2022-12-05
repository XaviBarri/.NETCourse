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
            ColeccionProfesores tabla = new ColeccionProfesores();
            
            tabla.Add("Cálculo", new Profesor() { Nombre = "Paula", Apellidos = "Fernández" });
            tabla.Add("Ingles", new Profesor() { Nombre = "Pedro", Apellidos = "Pérez" });
            tabla.Add("Robótica", new Profesor() { Nombre = "Manolo", Apellidos = "García" });
            tabla.Add("Electrónica", new Profesor() { Nombre = "Javier", Apellidos = "Ruíz" });
            tabla.Add("Programación", new Profesor() { Nombre = "Nuria", Apellidos = "Martínez" });

            foreach(DictionaryEntry profesor in tabla)
            {
                Console.WriteLine($"{profesor.Key} => {((Profesor)profesor.Value).Nombre} {((Profesor)profesor.Value).Apellidos}");
            }

            Console.WriteLine("Lista de asignaturas:");
            foreach(string clave in tabla.Claves)
            {
                Console.WriteLine(clave);
            }

            Console.WriteLine("Acceso por índice");
            tabla["Robótica"].Nombre = "Rubén";
            tabla["Robótica"].Apellidos = "Rubio";
            tabla["Robótica"].MostrarNombre();

            Console.ReadLine();
        }
    }

    public class ColeccionProfesores : System.Collections.DictionaryBase
    {
        public ICollection Claves
        {
            get { return Dictionary.Keys; }
        }

        public ICollection Valores
        {
            get { return Dictionary.Values; }
        }

        public void Add(string key, Profesor value)
        {
            //Dictionary.Add(key, value);
            InnerHashtable.Add(key, value);
        }

        public Profesor this[string clave]
        {
            get
            {
                return (Profesor)Dictionary[clave];
            }
            set
            {
                Dictionary[clave] = value;
            }
        }

        protected override void OnInsert(object key, object value)
        {
            Console.WriteLine($"OnInsert => {key}");
            base.OnInsert(key,value);
        }

        protected override void OnInsertComplete(object key, object value)
        {
            Console.WriteLine($"OnInsertComplete => {key}");
            base.OnInsertComplete(key,value);
        }
    }
}