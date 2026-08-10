namespace calzados;

public class Color
{
    public int idColor {get; set;}
    public string nombre {get; set;}
    public Color(int idColor,string nombre)
    {
        this.idColor = idColor;
        nombre=nombre;
    }
}