using Core.Entidades;
using Core.Dto;
using Core.IService;
using Core.IRepositorio;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointsCliente
{
    public static void MapEndpointsCliente(this WebApplication app)
    {
        app.MapPost("/clientes", (Cliente cliente, IClienteService service) =>
        {
            var resultado = service.AltaCliente(cliente);
            return resultado.Success
                ? Results.Created($"/clientes/{resultado.Data!.idCliente}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}
