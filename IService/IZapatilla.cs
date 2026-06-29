using calzados;
namespace calzadosIService;

public interface IZapatillaService
{
    Result<IEnumerable<Zapatilla>> GetZapatilla();
    Result<Zapatilla> AltaZapatilla (Zapatilla zapatilla );
}