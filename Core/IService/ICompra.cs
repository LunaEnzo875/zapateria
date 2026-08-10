using calzados;
namespace calzadosIService;

public interface ICompraService
{
    Result<IEnumerable<Com>> GetClientes();
    Result<DetalleCompraDto> AltaCliente(Cliente cliente);
}