namespace calzados;

public class Compra
{
    public int numeroCompra {get; set;}
    public Cliente cliente {get; set;}
    public DateTime fechaHora {get; set;}
    public Compra (int numeroCompra,Cliente cliente,DateTime fechaHora)
    {
        this.numeroCompra=numeroCompra;
        cliente = cliente;
        fechaHora = fechaHora;
    }
}