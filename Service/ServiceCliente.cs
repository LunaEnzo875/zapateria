using calzados;
using calzadosIService;
using calzadodto;
namespace ServiceZapatos;

public class ServiceCliente : IClienteService
{
    readonly IClienteService _ICliente;
    readonly 
    public ClienteService (IClienteService ICliente)
    {
        _ICliente = ICliente;
    }


    public Result<IEnumerable<ClienteDto>> GetClientes() => Result<IEnumerable<ClienteDto>>.Ok(_ICliente.GetClientes());
}