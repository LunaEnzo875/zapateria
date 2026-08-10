namespace ZapatosRepo;

public interface IRepoDetalleCompra
{
    IEnumerable<DetalleCompraDto> GetDetalleCompra();
    DetalleCompra? DetalleCompra(int idDetalleCompra);
}