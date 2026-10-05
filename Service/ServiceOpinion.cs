using calzadosIService;
using Core.Entidades;
using Core.IRepositorio;

namespace ServiceZapatos;

public class ServiceOpinion : IOpinionServie
{
    private readonly IRepoOpinion _repoOpinion;

    public ServiceOpinion(IRepoOpinion repoOpinion)
    {
        _repoOpinion = repoOpinion;
    }

    public Result<IEnumerable<Opinion>> GetOpinion() => throw new NotImplementedException();

    public Result<Opinion> AltaOpinion(Opinion opinion)
    {
        if (!_repoOpinion.ExisteModelo(opinion.idModelo))
            return Result<Opinion>.NotFound($"No se encontró el modelo con id {opinion.idModelo}");

        if (!_repoOpinion.ExisteCliente(opinion.dni))
            return Result<Opinion>.NotFound($"No se encontró el cliente con DNI {opinion.dni}");

        if (opinion.puntaje < 0 || opinion.puntaje > 5)
            return Result<Opinion>.BadRequest(message: "La nota debe estar entre 0 y 5");

        if (opinion.descripcion is null || opinion.descripcion.Length > 45)
            return Result<Opinion>.BadRequest(message: "La descripción debe tener entre 1 y 45 caracteres");

        if (!_repoOpinion.ClienteComproModelo(opinion.dni, opinion.idModelo))
            return Result<Opinion>.Forbidden("El cliente no compró zapatillas de este modelo");

        if (_repoOpinion.ExisteOpinion(opinion.idModelo, opinion.fechaHora, opinion.dni))
            return Result<Opinion>.Conflict("Ya existe una opinión con esa clave");

        _repoOpinion.AltaOpinion(opinion);
        return Result<Opinion>.Created(opinion);
    }
}