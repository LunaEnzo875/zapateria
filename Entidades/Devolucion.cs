namespace calzados;

public class Devolucion
{
    public int idDevolucion {get; set;}
    public DateTime fechaHora {get; set;}
    public int numeroCompra {get; set;}
    public int idRazon {get; set;}
    public Devolucion (int idDevolucion,DateTime fechaHora,int numeroCompra,int idRazon)
    {
        this.idDevolucion = idDevolucion;
        fechaHora = fechaHora;
        this.numeroCompra = numeroCompra;
        this.idRazon = idRazon;
    }
}