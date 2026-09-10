using Core.Dto;
using Core.Entidades;

namespace Core.IService;

public interface IRazonDevolucion
{
    Result<IEnumerable<RazonDevolucion>> GetRazonDevolucion();
    Result<RazonDevolucion> DetalleDevolucion(int idDevolucion);
    Result<RazonDevolucionDto> AltaRazon();     
}
