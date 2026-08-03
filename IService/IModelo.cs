using calzados;
namespace calzadosIService;

public interface IModeloService
{
    Result<IEnumerable<Modelo>> GetModelo();
    Result<ModeloDto> AltaModelo(Modelo modelo);
}