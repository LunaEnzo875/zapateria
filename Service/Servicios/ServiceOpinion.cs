using calzadosIService;
using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;

namespace ServiceZapatos;

public class ServiceOpinion : IOpinionService
{
    private readonly IRepoOpinion _repoOpinion;


    public ServiceOpinion(IRepoOpinion repoOpinion)
    {
        _repoOpinion = repoOpinion;
    }

    public Result<IEnumerable<OpinionDto>> GetOpinion() => Result<IEnumerable<OpinionDto>>.Ok(_repoOpinion.GetOpinion());
    public Result<Opinion> AltaOpinion(Opinion opinion)
    {
        if (!_repoOpinion.ExisteModelo(opinion.idModelo))
            return Result<Opinion>.NotFound($"No se encontró el modelo con id {opinion.idModelo}");

        if (!_repoOpinion.ExisteCliente(opinion.idOpinion))
            return Result<Opinion>.NotFound($"No se encontró el cliente con DNI {opinion.idOpinion}");

        if (!_repoOpinion.ClienteComproModelo(opinion.idOpinion, opinion.idModelo))
            return Result<Opinion>.Forbidden("El cliente no compró zapatillas de este modelo");

        if (_repoOpinion.ExisteOpinion(opinion.idModelo, opinion.fechaHora, opinion.idOpinion))
            return Result<Opinion>.Conflict("Ya existe una opinión con esa clave");

        _repoOpinion.AltaOpinion(opinion);
        return Result<Opinion>.Created(opinion);
    }


}