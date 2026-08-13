using System.Data;
using Core.IService;
namespace ZapatosRepo;
public abstract class Repo
{
    protected IDbConnection _conexion;
    public Repo(IAdo _ado) => _conexion = _ado.GetDbConnection();
}