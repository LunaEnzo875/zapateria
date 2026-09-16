using Core.IRepositorio;
using Core.Dto;
using Core.IService;
using Core.Entidades;

namespace ServiceZapatos;

public class ServiZapato : IDevolucionService
{
    public readonly IRepoDevolucion _repositorioRazonDevolucion;

    public ServiZapato(IRepoDevolucion repoDevolucion)
    {
        _repositorioRazonDevolucion = repoDevolucion;
    }

    public Result<IEnumerable<DevolucionDto>> GetDevolucion() => Result<IEnumerable<DevolucionDto>>.Ok(_repositorioRazonDevolucion.GetDevolucion());

    public Result<Devolucion> DetalleDevolucion(int idDevolucion)
    {
        var devolucion = _repositorioRazonDevolucion.DetalleDevolucion(idDevolucion);
        return devolucion is null
            ? Result<Devolucion>.NotFound($"No se encontró la devolución con id {idDevolucion}")
            : Result<Devolucion>.Ok(devolucion);
    }

    public Result<Devolucion> AltaDevolucion(Devolucion razonDevolucion)
    {
        _repositorioRazonDevolucion.AltaDevolucion(razonDevolucion);
        return Result<Devolucion>.Created(razonDevolucion);
    }
}