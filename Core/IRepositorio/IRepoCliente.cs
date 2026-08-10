namespace ZapatosRepo;

public interface IRepoCliente
{
    IEnumerable<Cliente> GetClientes();
    Cliente? DetalleCliente(int idCliente);
    void AltaCliente(Cliente cliente);
    void UpdateCliente(Cliente cliente, int id);
    Cliente? DetalleClienteXIdUsuario(int idUsuario);
}
