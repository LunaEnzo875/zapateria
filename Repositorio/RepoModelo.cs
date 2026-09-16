using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;

namespace ZapatosRepo;

public class RepoModelo : Repo, IRepoModelo
{
    private readonly IAdo _ado;

    public RepoModelo(IAdo _ado) : base(_ado)
    {
        this._ado = _ado;
    }

    private static readonly string _altaModelo = @"INSERT INTO Modelo (idModelo, idFabricante, nombre, idPaisOrigen)
    VALUES (@idModelo, @idFabricante, @Nombre, @idPaisOrigen);";

    public void AltaModelo(ModeloDto modelo)
    {
        _conexion.Execute(_altaModelo, new
        {
            modelo.idModelo,
            modelo.idFabricante,
            modelo.Nombre,
            modelo.idPaisOrigen,
        });
    }

    private static readonly string _modelo = "SELECT * FROM Modelo";

    public IEnumerable<ModeloDto> GetModelo() => _conexion.Query<ModeloDto>(_modelo);

    private static readonly string _detalleModelo = "SELECT * FROM Modelo WHERE idModelo = @idModelo";

    public ModeloDto? DetalleModelo(int idModelo)
    {
        return _conexion.QueryFirstOrDefault<ModeloDto>(_detalleModelo, new { idModelo });
    }
}
