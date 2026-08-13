using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoDevolucion
{
    IEnumerable<DevolucionDto> GetDevolucion();
    Devolucion? Devolucion(int idDevolucion);
}