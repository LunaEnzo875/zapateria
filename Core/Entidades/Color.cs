namespace Core.Entidades;

public class Color
{
    public int idColor { get; set; }
    public string nombre { get; set; }

    public Color()
    {
        nombre = string.Empty;
    }

    public Color(int idColor, string nombre)
    {
        this.idColor = idColor;
        this.nombre = nombre;
    }
}