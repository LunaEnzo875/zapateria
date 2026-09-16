using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface IModeloService
{
    Result<IEnumerable<ModeloDto>> GetModelo();
    Result<ModeloDto> DetalleModelo(int idModelo);
    Result<ModeloDto> AltaModelo(Modelo modelo);
}