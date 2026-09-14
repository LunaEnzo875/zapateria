using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;

namespace ZapatosRepo;

public class RepoColor : Repo, IRepoColor
{
    private readonly IAdo _ado;

    public RepoColor(IAdo _ado) : base(_ado)
    {
        this._ado = _ado;
    }

    private static readonly string _altaColor 
    = @"INSERT INTO Color (idColor, nombre)
    VALUES (@idColor, @Nombre);";

    public void AltaColor(ColorDto color)
    {
        _conexion.Execute(_altaColor, new { color.idColor, color.Nombre });
    }

    private static readonly string _detalleColor = "SELECT * FROM Color WHERE idColor = @idColor";

    public ColorDto? DetalleColor(int idColor)
    {
        return _conexion.QueryFirstOrDefault<ColorDto>(_detalleColor, new { idColor });
    }

    private static readonly string _Color = "SELECT * FROM Color";

    public IEnumerable<ColorDto> GetColor() => _conexion.Query<ColorDto>(_Color);
}