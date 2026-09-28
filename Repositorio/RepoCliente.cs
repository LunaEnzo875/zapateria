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
        const string query = 
        @"INSERT INTO Cliente (dni, nombre, apellido, nacimiento, correo)
        VALUES (@dni, @nombre, @apellido, @nacimiento, @correo);
        SELECT LAST_INSERT_ID();";

        cliente.idCliente = _conexion.QuerySingle<int>(query, cliente);
    }

    private static readonly string _updateCliente = 
        @"UPDATE Cliente SET dni = @dni, nombre = @nombre, apellido = @apellido, nacimiento = @nacimiento, correo = @correo
        WHERE idCliente = @idCliente";
    public void UpdateCliente(Cliente cliente, int id)
    {
        _conexion.Execute(_updateCliente, new { cliente.dni, cliente.nombre, cliente.apellido, cliente.nacimiento, cliente.correo, idCliente = id });
    }

    public Cliente? DetalleClienteXIdUsuario(int idUsuario)
    {
        throw new NotImplementedException();
    }
}