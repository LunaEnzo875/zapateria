namespace calzados;

public class Devolucion
{
    public int idDevolucion {get; set;}
    public DateTime fechaHora {get; set;}
    public int dni {get; set;}
    public int idRazon {get; set;}
    public Devolucion (int idDevolucion,DateTime fechaHora,int dni,int idRazon)
    {
        this.idDevolucion = idDevolucion;
        fechaHora = fechaHora;
        this.dni = dni;
        this.idRazon = idRazon;
    }
}