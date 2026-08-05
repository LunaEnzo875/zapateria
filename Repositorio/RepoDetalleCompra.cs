namespace ZapatosRepo;

public class RepoDetalleCompra
{
    private static readonly string _DetCompra
        = "SELECT * FROM DetalleCompra";

    public IEnumerable<DetalleCompraDto> GetDetalleCompra() => _conexion.Query<DetalleCompra>(_DetCompra);
}