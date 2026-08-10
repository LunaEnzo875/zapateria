namespace ZapatosRepo;

public interface IRepoDevolucion
{
    IEnumerable<DevolucionDto> GetDevolucion();
    Devolucion? Devolucion(int idDevolucion);
}