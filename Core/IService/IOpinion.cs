using Core.Entidades;
using Core.Dto;

namespace calzadosIService;

public interface IOpinionServie
{
    Result<IEnumerable<Opinion>> GetOpinion();
    Result<Opinion> AltaOpinion(Opinion opinion );
}