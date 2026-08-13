using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface ICompraService
{
    Result<IEnumerable<Compra>> GetClientes();
    Result<DetalleCompraDto> AltaCliente(Cliente cliente);
}