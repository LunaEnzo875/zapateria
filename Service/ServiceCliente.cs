using Core.IRepositorio;
using Core.Dto;
using Core.IService;
using Core.Entidades;
using calzadosIService;

namespace ServiceZapatos;

public class ServiceCliente : IClienteService
{
    readonly IRepoCliente _ICliente;
    public ServiceCliente (IRepoCliente ICliente)
    {
        _ICliente = ICliente;
    }

    Result<IEnumerable<ClienteDto>> IClienteService.GetClientes()
    {
        throw new NotImplementedException();
    }
    public Result<ClienteDto> AltaCliente(Cliente cliente)
    {
        _ICliente.AltaCliente(cliente);
        return Result<ClienteDto>.Created(new ClienteDto
        {
            idCliente = cliente.idCliente,
            Nombre = cliente.nombre,
            apellido = cliente.apellido
        });
    }

    public Result<IEnumerable<ClienteDto>> GetClientes() => Result<IEnumerable<ClienteDto>>.Ok(_ICliente.GetClientes());

    public Result<ClienteDto> DetalleCliente(int idCliente)
    {
        throw new NotImplementedException();
    }
}