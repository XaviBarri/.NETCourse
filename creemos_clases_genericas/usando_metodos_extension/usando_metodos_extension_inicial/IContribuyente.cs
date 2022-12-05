namespace AppConsola
{
    interface IContribuyente
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void PagarImpuestos();
    }
}