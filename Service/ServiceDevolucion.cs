using Core.Entidades;
using Core.Dto;
using Core.IService;
using Core.IRepositorio;
namespace Service;

public class ServiceDevolucion : IDevolucionService
{
    readonly IRepoDevolucion _repoDevol;
    public ServiceDevolucion (IRepoDevolucion _repoDevol)
    {
        this._repoDevol = _repoDevol;
    }

    public Result<Devolucion> AltaDevolucion(Devolucion razonDevolucion)
    {
        _repoDevol.AltaDevolucion(razonDevolucion);
        return Result<Devolucion>.Created(razonDevolucion);
    }

    public Result<IEnumerable<DevolucionDto>> GetDevolucion()
    {
        throw new NotImplementedException();
    }

    public Result<IEnumerable<RazonDevolucion>> IDevolucionService()
    {
        throw new NotImplementedException();
    }

    
}

