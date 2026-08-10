namespace  calzados;

public class Zapatilla 
{
    public int idZapatilla {get; set;}
    public Modelo modelo {get; set;}
    public string nombre {get; set;}
    public int stock  {get; set;}
    
    public Zapatilla (int idZapatilla,Modelo modelo,string Nombre,int Stock)
    {
        this.idZapatilla = idZapatilla;
        modelo =  modelo;
        nombre = Nombre;
        stock = Stock;
    }
}