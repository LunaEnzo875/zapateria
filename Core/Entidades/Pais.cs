 namespace calzados;

public class Pais 
{
    public int idPais {get; set;}
    public string Nombre {get; set;}
    public Pais (int idPais,string nombre){
    this.idPais = idPais;
    Nombre = nombre;
    }
}