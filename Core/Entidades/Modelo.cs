namespace  Core.Entidades;

public class Modelo
{
    public int idModelo {get; set;}
    public int idFabricante {get; set;}
    public string nombre{get; set;}
    public int idPaisOrigen {get; set;}

    public long? Posicion { get; set; }
    public decimal? Promedio { get; set; }
    public int? CantidadOpiniones { get; set; }

    public Modelo(int idModelo,int idFabricante,string nombre,int idPaisOrigen,long Posicion,decimal Promedio, int CantidadOpiniones)
    {
        this.idModelo = idModelo;
        this.idFabricante=idFabricante;
        this.nombre = nombre;
        this.idPaisOrigen = idPaisOrigen;
        Posicion = Posicion;
        Promedio = Promedio;
        CantidadOpiniones = CantidadOpiniones;
    }
}