using MySql.Data.MySqlClient;
using System.Data;
namespace ZapatosRepo;
public class Ado : IAdo
{
    private readonly string _connection;
    public Ado(string connection)
    {
        _connection = connection;
    }

    public IDbConnection GetDbConnection()
    {
        return new MySqlConnection(_connection);
    }
}