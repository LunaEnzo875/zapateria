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

}