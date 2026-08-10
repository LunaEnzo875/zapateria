namespace calzados;

public class DetalleCompra
{
    public int numeroCompra {get; set;}
    public int idModelo {get; set;}
    public int talle {get; set;}
    public int idZapatilla {get; set;}
    public int precioUnitario {get; set;}
    public int cantidad {get; set;}

    public DetalleCompra (int numeroCompra, int idModelo, int talle, int idZapatilla, int precioUnitario, int cantidad)
    {
        this.numeroCompra = numeroCompra;
        this.idModelo = idModelo;
        talle = talle;
        this.idZapatilla = idZapatilla;
        precioUnitario = precioUnitario;
        cantidad= cantidad;
    }
}