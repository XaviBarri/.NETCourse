﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Rubén", "Rubio", new DateTime(1950, 3, 25));
            
            persona.MostrarNombre();

            Console.WriteLine(persona.Edad);

            Console.ReadLine();
        }
    }

    class Persona
    {
        private DateTime FechaNacimiento;

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Edad
        {
            get
            {
                return (int)(DateTime.Today.Subtract(FechaNacimiento).Days / 365.25);
            }
        }

        public Persona()
        {
            Nombre = "Sin nombre";
            Apellidos = "Sin apellidos";
            FechaNacimiento = DateTime.Today;
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        ~Persona()
        {
            Console.WriteLine("Clase finalizada");
        }

        public Persona(string nombre, string apellidos, DateTime fechaNacimiento)
            : this(nombre, apellidos)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos + " - Edad " + Edad.ToString());
        }
    }

    class Profesor : Persona
    {
        public string Asignatura { get; set; }
        public bool JefeEstudios { get; set; }
    }

    class Alumno : Persona
    {
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }
    }
}