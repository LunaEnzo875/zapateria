using calzadosIService;
using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
namespace ServiceZapatos;

public class ServiceDetCom : IDetallleCompraService
{
    readonly IRepoDetalleCompra repoDetalleCompra;
    public ServiceDetCom(IRepoDetalleCompra repoDetalleCompra)
    {
        this.repoDetalleCompra = repoDetalleCompra;
    }

    public Result<DetalleCompraDto> AltaDetallleCompra(DetalleCompra detalleCompra)
    {
        var dto = new DetalleCompraDto
        {
            numeroCompra = detalleCompra.numeroCompra,
            idModelo = detalleCompra.idModelo,
            talle = detalleCompra.talle,
            idZapatilla = detalleCompra.idZapatilla,
            precioUnitario = detalleCompra.precioUnitario,
            cantidad = detalleCompra.cantidad,
        };

        repoDetalleCompra.altaDetalleCompra(dto);
        return Result<DetalleCompraDto>.Created(dto);
    }

    public Result<IEnumerable<DetalleCompraDto>> GetDetallleCompra() => Result<IEnumerable<DetalleCompraDto>>.Ok(repoDetalleCompra.GetDetalleCompra());
}
