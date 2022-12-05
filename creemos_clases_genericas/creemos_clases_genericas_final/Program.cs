using System;
using System.Text;

namespace Sample_solution
{
    class Program
    {
        static void Main()
        {
            // Alumno alumno1 = new Alumno()
            // {
            //     Nombre = "Rubén",
            //     Apellidos = "Rubio",
            //     Referencia = 12
            // };

            // Alumno alumno2 = new Alumno()
            // {
            //     Nombre = "Rubén",
            //     Apellidos = "Rubio",
            //     Referencia = 13
            // };
            
            // Profesor profesor = new Profesor()
            // {
            //     Nombre = "profesor",
            //     Apellidos = "apellidos",
            //     Referencia = "ref"
            // };
            
            // AccionPersona<Alumno,int> accion = new AccionPersona<Alumno,int>();
            // accion.Persona = alumno1;
            // accion.Referencia = 1;

            // accion.Comparar(alumno2);

            Console.WriteLine("{0} == {1} => {2}", 5, 6, AccionPersona2.Comparar<int>(5,6));
            Console.WriteLine("{0} == {1} => {2}", 5, 6, AccionPersona2.Comparar(5,6));

            // AccionPersona<int> accion2 = new AccionPersona<int>();
            // accion2.Persona = 5;
            // accion2.Comparar(6);

            Console.ReadLine();
        }
    }

    public static class AccionPersona2
    {
        public static bool Comparar<T>(T numero1,T numero2)
            where T : struct
        {
            return numero1.Equals(numero2);
        }
    }

    public class AccionPersona<T,TReferencia>
        where T : IContribuyente<TReferencia>
        where TReferencia : struct
    {
        public TReferencia Referencia{get;set;}
        public T Persona {get;set;}

        public void Comparar(T OtraPersona)
        {
            Console.WriteLine($"Son personas iguales: {Persona.Nombre == OtraPersona.Nombre && Persona.Apellidos == OtraPersona.Apellidos}");

            Console.WriteLine($"Referencia: {Persona.Referencia}");

            // if(OtraPersona is Alumno)
            // {
            //     var alumno1 = Persona as Alumno;
            //     var alumno2 = OtraPersona as Alumno;

            //     Console.WriteLine($"Son alumnos iguales: {alumno1.Nombre == alumno2.Nombre && alumno1.Apellidos == alumno2.Apellidos}");
            // }
            // else if (OtraPersona is Profesor)
            // {
            //     var profesor1 = Persona as Profesor;
            //     var profesor2 = OtraPersona as Profesor;

            //     Console.WriteLine($"Son profesores iguales: {profesor1.Nombre == profesor2.Nombre && profesor1.Apellidos == profesor2.Apellidos}");
            // }
            // else
            //     Console.WriteLine(Persona.Equals(OtraPersona));
        }
    }
}