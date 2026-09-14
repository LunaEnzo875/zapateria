using Core.IRepositorio;
using Core.Dto;
using Core.IService;
using Core.Entidades;
using calzadosIService;

namespace ServiceZapatos;
public class ServiZapato : IDevolucionService
{
   public readonly IRepoDevolucion _repositorioRazonDevolucion;

    public ServiZapato(IRepoDevolucion repoDevolucion)
    {
        _repositorioRazonDevolucion = repoDevolucion;
    }



    public Result<RazonDevolucion> AltaDevolucion(RazonDevolucion razonDevolucion)
    {
        throw new NotImplementedException();
    }

    public Result<Devolucion> AltaDevolucion(Devolucion razonDevolucion)
    {
        throw new NotImplementedException();
    }

    public Result<Devolucion> DetalleDevolucion(int idDevolucion)
    {
        var devolucion = _repositorioRazonDevolucion.DetalleDevolucion(idDevolucion);
        return devolucion is null
            ? Result<Devolucion>.NotFound($"No se encontró la devolución con id {idDevolucion}")
            : Result<Devolucion>.Ok(devolucion);
    }

    Result<IEnumerable<RazonDevolucion>> GetDevolucion() =>  Result<IEnumerable<RazonDevolucion>>.Ok(_repositorioRazonDevolucion.GetDevolucion());

    Result<IEnumerable<DevolucionDto>> IDevolucionService.GetDevolucion()
    {
        throw new NotImplementedException();
    }
}