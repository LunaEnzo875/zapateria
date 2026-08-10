using calzados;
namespace calzadosIService;

public interface IOpinionServie
{
    Result<IEnumerable<Opinion>> GetOpinion();
    Result<OpinionDto> AltaOpinion(Opinion opinion );
}