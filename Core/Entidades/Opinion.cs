namespace Core.Entidades;

public class Opinion 
{
    public int idOpinion {get; set;}
    public int idModelo {get; set;}
    public DateTime fechaHora{get; set;}
    public string descripcion {get; set;}
    public decimal puntaje {get; set;}
    public Opinion (int idOpinion,int idModelo,DateTime FechaHora,string Descripcion,decimal Puntaje)
    {
        this.idOpinion = idOpinion;
        this.idModelo = idModelo;
        fechaHora = FechaHora;
        descripcion = Descripcion;
        puntaje = Puntaje;
    }
}