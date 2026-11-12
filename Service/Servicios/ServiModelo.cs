using Core.Entidades;
using Core.Dto;
using Core.IRepositorio;
using calzadosIService;

namespace ServiceZapatos;

public class ServiModelo : IModeloService
{
    private readonly IRepoModelo _repoModelo;

    public ServiModelo(IRepoModelo repoModelo)
    {
        _repoModelo = repoModelo;
    }

    public Result<IEnumerable<ModeloDto>> GetModelo() => Result<IEnumerable<ModeloDto>>.Ok(_repoModelo.GetModelo());

    public Result<ModeloDto> DetalleModelo(int idModelo)
    {
        var modelo = _repoModelo.DetalleModelo(idModelo);
        return modelo is null
            ? Result<ModeloDto>.NotFound($"No se encontró el modelo con id {idModelo}")
            : Result<ModeloDto>.Ok(modelo);
    }

    public Result<ModeloDto> AltaModelo(Modelo modelo)
    {
        var nuevoModelo = new ModeloDto
        {
            idModelo = modelo.idModelo,
            idFabricante = modelo.idFabricante,
            Nombre = modelo.nombre,
            idPaisOrigen = modelo.idPaisOrigen,
        };

        _repoModelo.AltaModelo(nuevoModelo);
        return Result<ModeloDto>.Created(nuevoModelo);
    }


    

    Result<IEnumerable<ModeloDto>> IModeloService.RankingModelo(int idFabricante, int idPaisOrigen, int CantidadOpinion = 1)
    {
    if (idFabricante <= 0)
        return Result<IEnumerable<ModeloDto>>.BadRequest("El id del fabricante no es válido");

    if (idPaisOrigen <= 0)
        return Result<IEnumerable<ModeloDto>>.BadRequest("El id del país no es válido");

    if (CantidadOpinion < 1)
        return Result<IEnumerable<ModeloDto>>.BadRequest("La cantidad mínima de opiniones debe ser al menos 1");

    var ranking = _repoModelo.RankingModelo(idFabricante, idPaisOrigen, CantidadOpinion).ToList();

    return ranking.Count == 0
        ? Result<IEnumerable<ModeloDto>>.NotFound("No hay modelos que cumplan con el mínimo de opiniones")
        : Result<IEnumerable<ModeloDto>>.Ok(ranking);
    }
}
