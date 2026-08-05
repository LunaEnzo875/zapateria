using calzadodto;
using caldos;
namespace ZapatosRepo;

public class RepoDevolucion
{
    private static readonly string _Devol
    = "SELECT * FROM Devolucion";
    public IEnumerable<DevolucionDto> GetDevolucion() => _conexion.Query<ColorDto>(_Devol);
}