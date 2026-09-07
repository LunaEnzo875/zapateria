using calzadosIService;
using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
namespace ServiceZapatos;

public class ServiceDetCom : IDetallleCompraService
{
    readonly IRepoDetalleCompra repoDetalleCompra;
    public ServiceDetCom(IRepoDetalleCompra repoDetalleCompra)
    {
        this.repoDetalleCompra = repoDetalleCompra;
    }

    public Result<DetalleCompraDto> AltaDetallleCompra(DetalleCompra detalleCompra)
    {
        throw new NotImplementedException();
    }


    public Result<IEnumerable<DetalleCompraDto>> GetDetallleCompra() => Result<IEnumerable<DetalleCompraDto>>.Ok(repoDetalleCompra.GetDetalleCompra());  
}
