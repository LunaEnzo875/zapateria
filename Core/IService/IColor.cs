using calzados;
namespace calzadosIService;

public interface IColorService
{
    Result<IEnumerable<Color>> GetColor();
    Result<ColorDto> AltaColor(Color color);
}