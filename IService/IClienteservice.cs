using calzados;
namespace calzadosIService;

public interface IClienteService
{
    Result<IEnumerable<Cliente>> GetClientes();
    Result<ClienteDto> AltaCliente(Cliente cliente);
}