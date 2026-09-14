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

    public Result<IEnumerable<DevolucionDto>> GetDevolucion() => Result<IEnumerable<DevolucionDto>>.Ok(_repoDevol.GetDevolucion());//Result<IEnumerable<DevolucionDto>>.Ok(_repoDevol.GetDevolucion());

    public Result<Devolucion> DetalleDevolucion(int idDevolucion)
    {
        var devolucion = _repoDevol.DetalleDevolucion(idDevolucion);
        return devolucion is null
            ? Result<Devolucion>.NotFound($"No se encontró la devolución con id {idDevolucion}")
            : Result<Devolucion>.Ok(devolucion);
    }

    public Result<Devolucion> AltaDevolucion(Devolucion razonDevolucion)
    {
        _repoDevol.AltaDevolucion(razonDevolucion);
        return Result<Devolucion>.Created(razonDevolucion);
    }
}

