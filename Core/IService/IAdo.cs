using System.Data;

namespace Core.IService;
public interface IAdo
{
    IDbConnection GetDbConnection();
}
