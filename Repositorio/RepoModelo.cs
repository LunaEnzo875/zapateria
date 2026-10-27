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

    public IEnumerable<ModeloDto> GetModelo()
    {
        return _conexion.Query<ModeloDto>(_modelo);
    }

    private static readonly string _detalleModelo = "SELECT * FROM Modelo WHERE idModelo = @idModelo";

    public ModeloDto? DetalleModelo(int idModelo)
    {
        return _conexion.QueryFirstOrDefault<ModeloDto>(_detalleModelo, new { idModelo });
    }


    private static readonly string _RankingModelo = "SELECT *RANK() OVER (ORDER BY AVG(o.puntaje) DESC, COUNT(*) DESC) AS Posicion, m.idModelo, m.idFabricante, m.nombre AS Nombre, m.idPaisOrigen, ROUND(AVG(o.puntaje), 2) AS Promedio, COUNT(*) AS CantidadOpiniones FROM Opinion O WHERE m.idFabricante = @idFabricante AND m.idPaisOrigen = @idPaisOrigen GROUP BY m.idModelo, m.idFabricante, m.nombre, m.idPaisOrigen HAVING COUNT(*) >= @cantidadOpinion ORDER BY Posicion;" ;

    public IEnumerable<ModeloDto> RankingModelo(int idFabricante, int idPais,int CantidadOpinion)
    {
        return _conexion.Query<ModeloDto>(_RankingModelo, new
        {
            idFabricante,
            idPais,
            CantidadOpinion
        });
    }

 
}
