using System.Drawing;
using Core.Entidades;
using Core.Dto;
namespace Core.IRepositorio;

public interface IRepoColor
{
    IEnumerable<ColorDto> GetClientes();
    ColorDto? DetalleCliente(int idColor);
    void AltaCliente(ColorDto color);
}