using Core.Entidades;
using Core.Dto;

namespace calzadosIService;

public interface IOpinionService
{
    Result<IEnumerable<OpinionDto>> GetOpinion();
    Result<Opinion> AltaOpinion(Opinion opinion);
}