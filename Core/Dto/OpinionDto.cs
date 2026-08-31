using Core.Entidades;

namespace Core.Dto;

public class OpinionDto
{
    public int idModelo {get; set;}
    public ClienteDto Nombre {get; set;}
    public DateTime fechaHora{get; set;}
    public string descripcion {get; set;}
    public decimal puntaje {get; set;}
}