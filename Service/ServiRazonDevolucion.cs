using Core.IRepositorio;
using Core.Dto;
using Core.IService;
using Core.Entidades;
using calzadosIService;

namespace ServiceZapatos;

public class ServiDevolucion : IDevolucionService
{
   public readonly IRepoDevolucion _repoDevolucion;

    public ServiDevolucion(IRepoDevolucion repoDevolucion)
    {
        _repoDevolucion = repoDevolucion;
    }

     Result<IEnumerable<DevolucionDto>> IDevolucionService.GetDevolucion()
    {
        throw new NotImplementedException();
    }
    
    public Result<Devolucion> AltaDevolucion(Devolucion Devolucion)
    {
        throw new NotImplementedException();
    }

    public Result<IEnumerable<RazonDevolucion>> GetDevolucion() =>  Result<IEnumerable<RazonDevolucion>>.Ok(_repoDevolucion.GetDevolucion());

   
}
