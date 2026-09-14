namespace  Core.Entidades;

public class Fabricante 
{
    public int idFabricante { get; set; }
    public string NombreFab { get; set; } = string.Empty;

    public Fabricante()
    {
    }

    public Fabricante(int idFabricante, string nombreFab)
    {
        this.idFabricante = idFabricante;
        NombreFab = nombreFab;
    }
}