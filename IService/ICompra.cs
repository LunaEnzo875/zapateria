using calzados;
namespace calzadosIService;

public interface ICompraService
{
    Result<IEnumerable<Com>> GetClientes();
    Result<ClienteResponse> AltaCliente(Cliente cliente);
}