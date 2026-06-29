using calzados;
namespace calzadosIService;

public interface IDetallleCompraService
{
    Result<IEnumerable<DetallleCompra>> GetDetallleCompra();
    Result<DetallleCompra> AltaDetallleCompra (DetallleCompra detallleCompra);
}