using Core.IRepositorio;
using Core.Dto;
using Core.IService;
using Core.Entidades;
using calzadosIService;

namespace ServiceZapatos;

public class ServiDevolucion : IDevolucionService
{
   public readonly IRepoDevolucion _repositorioDevolucion;

    public ServiDevolucion(IRepoDevolucion repoDevolucion)
    {
        _repositorioDevolucion = repoDevolucion;
    }

    Result<IEnumerable<Devolucion>> IDevolucionService.GetDevolucion()
    {
        return GetDevolucion();
    }

    public Result<Devolucion> AltaDevolucion(Devolucion Devolucion)
    {
        throw new NotImplementedException();
    }

    public Result<IEnumerable<Devolucion>> GetDevolucion() =>  Result<IEnumerable<Devolucion>>.Ok(_repositorioDevolucion.GetDevolucion());

   
}
