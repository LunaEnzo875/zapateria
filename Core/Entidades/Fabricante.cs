namespace  Core.Entidades;

public class Fabricante 
{
    public int idFabricante {get; set;}
    public string NombreFab {get; set;}
    public Fabricante(int idFabricante,string NombreFab)
    {
        this.idFabricante = idFabricante;
        NombreFab = NombreFab;
    }
}