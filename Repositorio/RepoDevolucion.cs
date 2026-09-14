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

    private static readonly string _detalleDevolucion = "SELECT * FROM Devolucion WHERE idDevolucion = @idDevolucion";

    public Devolucion? DetalleDevolucion(int idDevolucion)
    {
        return _conexion.QuerySingleOrDefault<Devolucion?>(_detalleDevolucion, new { idDevolucion });
    }

    private static readonly string _altaDevolucion
        = @"INSERT INTO Devolucion (dni, idRazon, fechaHora)
            VALUES (@dni, @idRazon, @fechaHora);
            SELECT LAST_INSERT_ID();";

    public void AltaDevolucion(Devolucion devolucion)
    {
        devolucion.idDevolucion = _conexion.QuerySingle<int>(_altaDevolucion, devolucion);
    }

    private static readonly string _Devol
    = "SELECT * FROM Devolucion";

    public IEnumerable<DevolucionDto> GetDevolucion() => _conexion.Query<DevolucionDto>(_Devol);
    
}