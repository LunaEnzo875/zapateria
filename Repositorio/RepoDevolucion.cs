using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;
namespace ZapatosRepo;

public class RepoDevolucion : Repo, IRepoDevolucion
{
    private readonly IAdo _ado;
    public RepoDevolucion(IAdo _ado) : base(_ado)
    {
        this._ado = _ado;
    }
    public Devolucion? Devolucion(int idDevolucion)
    {
        throw new NotImplementedException();
    }    
    private static readonly string _Devol
    = "SELECT * FROM Devolucion";

    public IEnumerable<DevolucionDto> GetDevolucion() => _conexion.Query<DevolucionDto>(_Devol);//_conexion.Query<ColorDto>(_Devol);
    
}