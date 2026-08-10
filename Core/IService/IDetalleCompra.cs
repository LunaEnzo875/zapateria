using calzados;
namespace calzadosIService;

public interface IDetallleCompraService
{
    Result<IEnumerable<DetallleCompra>> GetDetallleCompra();
    Result<DetalleCompraDto> AltaDetallleCompra (DetallleCompra detallleCompra);
}