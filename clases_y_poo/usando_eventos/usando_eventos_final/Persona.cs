using System;
using System.IO;
using System.Xml.Serialization;

namespace AppConsola
{
    //public delegate void DatosCambiadosEventHandler(string campo, string valorAnterior, string valorNuevo);

    public class Persona
    {
        //public event DatosCambiadosEventHandler OnChange;
        public event EventHandler OnChange;

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value)
                {
                    /*
                    if(OnChange != null)
                    OnChange();
                    */

                    OnChange?.Invoke(this, new DemoEventArgs()
                    {
                        Campo = "Nombre",
                            ValorAnterior = nombre,
                            ValorNuevo = value
                    });
                }

                nombre = value;
            }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                if (apellidos != value)
                {
                    OnChange?.Invoke(this, new DemoEventArgs()
                    {
                        Campo = "Apellidos",
                            ValorAnterior = apellidos,
                            ValorNuevo = value
                    });
                }

                apellidos = value;
            }
        }

        private DateTime fechaNacimiento;

        public static int NumeroCreacionesEstatica { get; set; }
        public DateTime FechaNacimiento
        {
            set
            {
                if (value > DateTime.Today)
                {
                    fechaNacimiento = value;
                }
            }
        }

        public int Edad
        {
            get
            {
                return (int) (DateTime.Today.Subtract(fechaNacimiento).Days / 365.25);
            }
        }

        public virtual void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }
    }

    public class DemoEventArgs : EventArgs
    {
        public string Campo { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
    }
}