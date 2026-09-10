using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface IColorService
{
    Result<IEnumerable<Color>> GetColor();
    Result<ClienteDto>DetalleColor(int idColor);
    Result<ColorDto> AltaColor(Color color);
}