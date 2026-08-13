using Core.Entidades;
using Core.IService;
using Core.Dto;
using Core.IService;
using Core.IRepositorio;
using calzadosIService;
namespace ServiceZapatos;

public class ServiceColor : IColorService
{
    readonly IRepoColor _IColor;
    public ServiceColor (IRepoColor IColor)
    {
        _IColor = IColor;
    }

    public Result<ColorDto> AltaColor(Color color)
    {
        throw new NotImplementedException();
    }

    public Result<IEnumerable<ColorDto>> GetColor() => Result<IEnumerable<ColorDto>>.Ok(_IColor.GetColor());

    Result<IEnumerable<Color>> IColorService.GetColor()
    {
        throw new NotImplementedException();
    }
}