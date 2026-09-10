using Core.Dto;
using Core.IRepositorio;
using Core.IService;
using Dapper;
using System.Drawing;
namespace ZapatosRepo;

public class RepoColor : Repo, IRepoColor
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
    ColorDto? IRepoColor.DetalleColor(int idColor)
    {
        throw new NotImplementedException();
    }

    private static readonly string _Color
        = "SELECT * FROM Color";
   

    public IEnumerable<ColorDto> GetColor() => _conexion.Query<ColorDto>(_Color); 

    private static readonly string _DetalleColor
    = "SELECT * FROM Color WHERE  idColor = idColor";
    public Color DetalleColor (int idColor)
    {
        return _conexion.QueryFirstOrDefault<Color>(_DetalleColor, new {idColor});
    }

    
}