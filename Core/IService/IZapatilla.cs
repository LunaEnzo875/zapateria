using calzados;
namespace calzadosIService;

public interface IZapatillaService
{
    Result<IEnumerable<Zapatilla>> GetZapatilla();
    Result<ZapatillaDto> AltaZapatilla (Zapatilla zapatilla );
}