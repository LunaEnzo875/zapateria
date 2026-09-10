using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;
namespace ZapatosRepo;

public class RepoFabricante : Repo,IRepoFabricante
{
    private readonly IAdo _ado;
    public RepoFabricante(IAdo _ado) : base(_ado)
    {this._ado = _ado;
    }
    public IEnumerable<FabricanteDto> GetFabricante()
    {
        throw new NotImplementedException();
    }

    public Fabricante? Fabricante(int idFabricante)
    {
        throw new NotImplementedException();
    }
    private static string _Fabricante

    = "SELECT * FROM fabricante";

    public IEnumerable<FabricanteDto> GetClientes() => _conexion.Query<FabricanteDto>(_Fabricante);

    public Fabricante? DetalleFabricante(int idFabricante)
    {
        throw new NotImplementedException();
    }
}