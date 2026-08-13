using Core.Dto;
using Core.Entidades;

namespace calzadosIService;

public interface IClienteService
{
    Result<IEnumerable<ClienteDto>> GetClientes();
    Result<ClienteDto> AltaCliente(Cliente cliente);
}