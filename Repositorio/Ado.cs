using Core.IService;
using MySqlConnector;
using System.Data;
namespace ZapatosRepo;
public class Ado : IAdo
{
    private readonly string _conexion;
    public Ado(IDataBaseConnectionService _service, IGetRolActualService _serviceRol) => _conexion = _service.GetConnectionUserString(_serviceRol.GetRolActual());

    public IDbConnection GetDbConnection()
    {
        return new MySqlConnection(_conexion);
    }    
}