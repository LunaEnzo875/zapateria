namespace  Core.Entidades;

public class Zapatilla 
{
    public int idZapatilla {get; set;}
    public Modelo modelo {get; set;}
    public int talla {get; set;}
    public string nombre {get; set;}
    public int stock  {get; set;}
    
    public Zapatilla (int idZapatilla,Modelo modelo,int Talla,string Nombre,int Stock)
    {
        this.idZapatilla = idZapatilla;
        modelo =  modelo;
        talla = Talla;
        nombre = Nombre;
        stock = Stock;
    }
}