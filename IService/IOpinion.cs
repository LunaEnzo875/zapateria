using calzados;
namespace calzadosIService;

public interface IOpinionServie
{
    Result<IEnumerable<Opinion>> GetOpinion();
    Result<Opinion> AltaOpinion(Opinion opinion );
}