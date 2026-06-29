using calzados;


namespace calzadosIService;

public interface IClienteService
{
    Result<IEnumerable<Cliente>> GetClientes();
    Result<ClienteResponse> AltaCliente(Cliente cliente);
}