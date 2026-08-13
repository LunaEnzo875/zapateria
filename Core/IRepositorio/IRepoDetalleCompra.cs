using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoDetalleCompra
{
    IEnumerable<DetalleCompraDto> GetDetalleCompra();
    DetalleCompra? DetalleCompra(int idDetalleCompra);
}