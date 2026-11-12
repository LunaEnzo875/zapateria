using Core.IService;

namespace Api;

public sealed class DatabaseConnectionService : IDataBaseConnectionService
{
    private readonly IConfiguration _configuration;

    public DatabaseConnectionService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetConnectionRootString()
    {
        return _configuration.GetConnectionString("DefaultConnection")
            ?? Environment.GetEnvironmentVariable("ZAPATERIA_CONNECTION_STRING")
            ?? "Server=localhost;Database=5to_Calzados;Uid=5to_agbd;Pwd=Trigg3rs!;";
    }

    public string GetConnectionUserString(string rol)
    {
        return GetConnectionRootString();
    }
}

public sealed class CurrentRolService : IGetRolActualService
{
    public string GetRolActual()
    {
        return Environment.GetEnvironmentVariable("ZAPATERIA_ROLE") ?? "root";
    }
}
