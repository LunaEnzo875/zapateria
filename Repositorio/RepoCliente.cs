using MySql.Data.MySqlClient;
using Core.IService;
using Core.Dto;
using Core.Entidades;
namespace ZapatosRepo;

public class Repocliente
{
    private readonly IAdo _ado;
    private static readonly string _Clientes
        = "SELECT * FROM Cliente";
    public IEnumerable<ClienteDto> GetClientes() => _conexion.Query<ClienteDto>(_Clientes);

    private static readonly string _queryDetalleCliente 
        = @"SELECT * FROM Cliente WHERE DNI = @DNI"; 
    public Cliente? DetalleCliente(int DNI) 
    {
        return _conexion.QueryFirstOrDefault<Cliente>(_queryDetalleCliente, new { idCliente });
    }
}