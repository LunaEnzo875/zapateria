namespace ZapatosRepo;

public interface IRepoDetalleCompra
{
    IEnumerable<ClienteResponse> GetClientes();
    Cliente? DetalleCliente(int idCliente);
}