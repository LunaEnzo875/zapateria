using System.Drawing;
using Core.Entidades;
using Core.Dto;
namespace Core.IRepositorio;

public interface IRepoColor
{
    IEnumerable<ColorDto> GetColor();
    ColorDto? DetalleColor(int idColor);
    Task<ColorDto?> ObtenerPorIdAsync(int idColor, CancellationToken cancellationToken = default);
    void AltaColor(ColorDto color);
}