using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface IZapatillaService
{
    Result<IEnumerable<Zapatilla>> GetZapatilla();
    Result<Zapatilla> DetalleZapatilla(int idZapatilla);
    Result<ZapatillaDto> AltaZapatilla (Zapatilla zapatilla );
}