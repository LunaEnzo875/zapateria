using calzados;
namespace calzadosIService;

public interface IModeloService
{
    Result<IEnumerable<Modelo>> GetModelo();
    Result<Modelo> AltaModelo(Modelo modelo);
}