using Core.IRepositorio;
using Core.Dto;
using Core.IService;
using Core.Entidades;
using calzadosIService;

namespace ServiceZapatos;

public class ServiRazonDevolucion : IDevolucionService
{
   public readonly IRepoDevolucion _repositorioRazonDevolucion;

    public ServiRazonDevolucion(IRepoDevolucion repoDevolucion)
    {
        _repositorioRazonDevolucion = repoDevolucion;
    }

    Result<IEnumerable<RazonDevolucion>> IDevolucionService.GetDevolucion()
    {
        return GetDevolucion();
    }

    public Result<RazonDevolucion> AltaDevolucion(RazonDevolucion razonDevolucion)
    {
        throw new NotImplementedException();
    }

     Result<IEnumerable<RazonDevolucion>> GetDevolucion() =>  Result<IEnumerable<RazonDevolucion>>.Ok(_repositorioRazonDevolucion.GetDevolucion());

   
}
