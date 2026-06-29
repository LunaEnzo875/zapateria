using calzados;
namespace calzadosIService;

public interface IColorService
{
    Result<IEnumerable<Color>> GetColor();
    Result<Color> AltaColor(Color color);
}