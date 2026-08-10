 namespace calzados;

public class Opinion 
{
    public int dni {get; set;}
    public int idModelo {get; set;}
    public DateTime fechaHora{get; set;}
    public string descripcion {get; set;}
    public decimal puntaje {get; set;}
    public Opinion (int dni,int idModelo,DateTime FechaHora,string Descripcion,decimal Puntaje)
    {
        this.dni = dni;
        this.idModelo = idModelo;
        fechaHora = FechaHora;
        descripcion = Descripcion;
        puntaje = Puntaje;
    }    
}