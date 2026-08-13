using MySql.Data.MySqlClient;
using Core.IService;
using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
namespace ZapatosRepo;

public class Repocliente : Repo, IRepoCliente
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

    public void AltaCliente(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public void UpdateCliente(Cliente cliente, int id)
    {
        throw new NotImplementedException();
    }

    public Cliente? DetalleClienteXIdUsuario(int idUsuario)
    {
        throw new NotImplementedException();
    }
}