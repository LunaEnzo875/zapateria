namespace ZapatosRepo;

public class Repocliente
{
    private static readonly string _queryClientes;
    private static readonly string _queryClientes
        = "SELECT * FROM Cliente";
    public IEnumerable<ClienteDto> GetClientes() => _conexion.Query<ClienteDto>(_queryClientes);

    private static readonly string _queryDetalleCliente 
        = @"SELECT * FROM Cliente WHERE DNI = @DNI"; 
    public Cliente? DetalleCliente(int DNI) 
    {
        return _conexion.QueryFirstOrDefault<Cliente>(_queryDetalleCliente, new { idCliente });
    }
}