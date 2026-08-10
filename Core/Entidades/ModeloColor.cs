using System.Drawing;

namespace calzados;

public class ModeloColor
{
    public Color color {get; set;}
    public Modelo modelo {get; set;}
    public ModeloColor(Color color,Modelo modelo)
    {
        color = color;
        modelo = modelo;
    }
}