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

    public Result<IEnumerable<DevolucionDto>> GetDevolucion() => Result<IEnumerable<DevolucionDto>>.Ok(_repoDevolucion.GetDevolucion());

    public Result<Devolucion> DetalleDevolucion(int idDevolucion)
    {
        var devolucion = _repoDevolucion.DetalleDevolucion(idDevolucion);
        return devolucion is null
            ? Result<Devolucion>.NotFound($"No se encontró la devolución con id {idDevolucion}")
            : Result<Devolucion>.Ok(devolucion);
    }

    public Result<Devolucion> AltaDevolucion(Devolucion devolucion)
    {
        _repoDevolucion.AltaDevolucion(devolucion);
        return Result<Devolucion>.Created(devolucion);
    }
}
