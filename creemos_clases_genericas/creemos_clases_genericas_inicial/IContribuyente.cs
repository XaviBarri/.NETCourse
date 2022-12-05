namespace Sample_solution
{
    interface IContribuyente
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void PagarImpuestos();
    }
}