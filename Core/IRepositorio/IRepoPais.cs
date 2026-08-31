using System;
using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio
{
    public interface IRepoPais
    {
        IEnumerable<PaisDto> GetPaises();
        Pais? DetallePais(int idPais);
    }
}