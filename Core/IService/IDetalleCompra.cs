using Core.Dto;
using Core.Entidades;

namespace calzadosIService;

public interface IDetallleCompraService
{
    Result<IEnumerable<DetalleCompraDto>> GetDetallleCompra();
    Result<DetalleCompraDto> AltaDetallleCompra (DetalleCompra detalleCompra);
}