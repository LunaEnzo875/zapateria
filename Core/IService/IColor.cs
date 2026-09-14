using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface IColorService
{
    Result<IEnumerable<ColorDto>> GetColor();
    Result<ColorDto> DetalleColor(int idColor);
    Result<ColorDto> AltaColor(Color color);
}