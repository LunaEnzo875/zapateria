using Core.Entidades;
using Core.Dto;
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
        var nuevoColor = new ColorDto
        {
            idColor = color.idColor,
            Nombre = color.nombre,
        };

        _IColor.AltaColor(nuevoColor);
        return Result<ColorDto>.Created(nuevoColor);
    }

    public Result<IEnumerable<ColorDto>> GetColor() => Result<IEnumerable<ColorDto>>.Ok(_IColor.GetColor());

    public Result<ColorDto> DetalleColor(int idColor)
    {
        var color = _IColor.DetalleColor(idColor);
        return color is null
            ? Result<ColorDto>.NotFound($"No se encontró el color con id {idColor}")
            : Result<ColorDto>.Ok(color);
    }
}