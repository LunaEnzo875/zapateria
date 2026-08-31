using MySql.Data.MySqlClient;
using Core.Dto;
using Core.IRepositorio;
using Core.IService;
using Dapper;
namespace ZapatosRepo;

public class RepoColor : Repo , IRepoColor
{
    private readonly IAdo _ado;
    public RepoColor(IAdo _ado) : base(_ado)
    {
        this._ado = _ado;
    }
        public void AltaColor(ColorDto color)
    {
        throw new NotImplementedException();
    }
    private static readonly string _Color
        = "SELECT * FROM Color";

    public ColorDto? DetalleColor(int idColor)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ColorDto> GetColor() => _conexion.Query<ColorDto>(_Color); //_conexion.Query<ColorDto>(_Color);
}