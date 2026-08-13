using Core.Dto;
using Core.Entidades;
namespace calzadosIService;

public interface IZapatillaService
{
    Result<IEnumerable<Zapatilla>> GetZapatilla();
    Result<ZapatillaDto> AltaZapatilla (Zapatilla zapatilla );
}