namespace  calzados;

public class Modelo
{
    public int idModelo {get; set;}
    public int idFabricante {get; set;}
    public string nombre{get; set;}
    public int idPaisOrigen {get; set;}

    public Modelo(int idModelo,int idFabricante,string nombre,int idPaisOrigen)
    {
        this.idModelo = idModelo;
        this.idFabricante=idFabricante;
        nombre = nombre;
        this.idPaisOrigen = idPaisOrigen;
    }
}