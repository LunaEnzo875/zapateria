using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoCliente
{
    IEnumerable<ClienteDto> GetClientes();
    Cliente? DetalleCliente(int idCliente);
    void AltaCliente(Cliente cliente);
    void UpdateCliente(Cliente cliente, int id);
    Cliente? DetalleClienteXIdUsuario(int idUsuario);
}
