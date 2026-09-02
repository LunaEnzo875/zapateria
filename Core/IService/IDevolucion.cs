using Core.Entidades;
using Core.Dto;
namespace Core.IService;

public interface IDevolucionService
    {
        Result<IEnumerable<RazonDevolucion>> GetDevolucion();
        Result<RazonDevolucion> AltaDevolucion(RazonDevolucion razonDevolucion);
    }
