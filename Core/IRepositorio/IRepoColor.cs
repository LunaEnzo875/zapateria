using System.Drawing;

namespace ZapatosRepo;

public interface IRepoColor
{
    IEnumerable<ColorDto> GetClientes();
    Color? DetalleCliente(int idColor);
    void AltaCliente(Color color);
}