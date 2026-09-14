using Core.Entidades;
using Core.Dto;
namespace Core.IService;

public interface IDevolucionService
{
    Result<IEnumerable<DevolucionDto>> GetDevolucion();
    Result<Devolucion> DetalleDevolucion(int idDevolucion);
    Result<Devolucion> AltaDevolucion(Devolucion razonDevolucion);
}
