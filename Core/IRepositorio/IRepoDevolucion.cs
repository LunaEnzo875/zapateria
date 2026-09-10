using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoDevolucion
{
    void AltaDevolucion(Devolucion devolucion);
    IEnumerable<DevolucionDto> GetDevolucion();
    Devolucion? DetalleDevolucion(int idDevolucion);
}