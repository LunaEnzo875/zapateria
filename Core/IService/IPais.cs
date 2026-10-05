using Core.Dto;
using Core.Entidades;

namespace Core.IService;
public interface IPais
{
    Result<IEnumerable<PaisDto>> GetPais();
    Result<PaisDto> DetallePais();
    Result<PaisDto> AltaPais();    
    
}
