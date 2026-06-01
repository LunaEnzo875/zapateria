namespace  calzados;

public class Modelo
{
    public int idModelo {get; set;}
    public Fabricante fabricante {get; set;}
    public string nombre{get; set;}
    public int idPaisOrigen {get; set;}

    public Modelo(int idModelo,Fabricante fabricante,string nombre,int idPaisOrigen)
    {
        this.idModelo = idModelo;
        fabricante=fabricante;
        nombre = nombre;
        idPaisOrigen = idPaisOrigen;
    }
}