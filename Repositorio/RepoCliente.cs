using MySql.Data.MySqlClient;
using Core.IService;
using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Dapper;
namespace ZapatosRepo;

public class Repocliente : Repo, IRepoCliente
{
    private readonly IAdo _ado;

    public Repocliente(IAdo _ado) : base(_ado)
    {
        this._ado = _ado;
    }

    private static readonly string _Clientes
        = "SELECT * FROM Cliente";
    public IEnumerable<ClienteDto> GetClientes() => _conexion.Query<ClienteDto>(_Clientes);

    private static readonly string _queryDetalleCliente 
        = @"SELECT * FROM Cliente WHERE idCliente = @idCliente";
    
    public Cliente? DetalleCliente(int idCliente) 
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