using calzados;
using calzadosIService;
using calzadodto;
namespace ServiceZapatos;

public class ServiceColor : IColorService
{
    readonly IColorService _IColor;
    readonly 
    public ClienteService (IColorService IColor)
    {
        _IColor = IColorr;
    }


    public Result<IEnumerable<ColorDto>> GetColor() => Result<IEnumerable<ColorDto>>.Ok(_IColor.GetColor());
}