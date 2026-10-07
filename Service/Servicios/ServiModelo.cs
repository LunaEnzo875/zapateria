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
}
