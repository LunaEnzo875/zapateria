namespace ZapatosRepo;

public interface IRepoColor
{
    IEnumerable<ClienteResponse> GetClientes();
    Cliente? DetalleCliente(int idCliente);
    void AltaCliente(Cliente cliente);
}