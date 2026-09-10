using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;
namespace ZapatosRepo;

public class RepoDetalleCompra : Repo , IRepoDetalleCompra
{
    
    private readonly IAdo _ado;
    public RepoDetalleCompra(IAdo _ado) : base(_ado)
    {this._ado = _ado;
    }
    public DetalleCompra? DetalleCompra(int idDetalleCompra)
    {
        throw new NotImplementedException();
    }
    private static readonly string _DetCompra
        = "SELECT * FROM DetalleCompra";
    public IEnumerable<DetalleCompraDto> GetDetalleCompra() => _conexion.Query<DetalleCompraDto>(_DetCompra);

    public void altaDetalleCompra(DetalleCompraDto DetalleCompra)
    {
        throw new NotImplementedException();
    }

   

    private static readonly string _DetalleDetCompra
    = "SELECT * FROM DetalleCompra WHERE numeroCompra = numeroCompra";
    public DetalleCompra detalleDetCompra(int numeroCompra)
    {
        throw new NotImplementedException();
    }

    public DetalleCompra? DetalleDetCompra(int idDetalleCompra)
    {
        throw new NotImplementedException();
    }
}