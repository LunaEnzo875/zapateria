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
    public Result<IEnumerable<RazonDevolucion>> IDevolucionService()
    {
        throw new NotImplementedException();
    }

    
}

