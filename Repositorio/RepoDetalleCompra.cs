using Core.Dto;
using Core.Entidades;
using Core.IService;
namespace ZapatosRepo;

public class RepoDetalleCompra
{
    private readonly IAdo _ado;
    private static readonly string _DetCompra
        = "SELECT * FROM DetalleCompra";

    public IEnumerable<DetalleCompraDto> GetDetalleCompra() => _conexion.Query<DetalleCompra>(_DetCompra);
}