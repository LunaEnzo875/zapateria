using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface IModeloService
{
    Result<IEnumerable<ModeloDto>> GetModelo();
    Result<ModeloDto> AltaModelo(Modelo modelo);
}