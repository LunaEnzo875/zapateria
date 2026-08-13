using Core.Dto;
using Core.IService;
namespace ZapatosRepo;

public class RepoDevolucion
{
    private readonly IAdo _ado;
    private static readonly string _Devol
    = "SELECT * FROM Devolucion";
    public IEnumerable<DevolucionDto> GetDevolucion() => _conexion.Query<ColorDto>(_Devol);
}