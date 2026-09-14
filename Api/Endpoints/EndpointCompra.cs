using Core.Entidades;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointsCompra
{
    public static void MapEndpointsCompra(this WebApplication app)
    {
        app.MapGet("/compras", (IDetallleCompraService service) =>
        {
            var resultado = service.GetDetallleCompra();
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapPost("/compras", (DetalleCompra detalleCompra, IDetallleCompraService service) =>
        {
            var resultado = service.AltaDetallleCompra(detalleCompra);
            return resultado.Success
                ? Results.Created($"/compras/{resultado.Data!.numeroCompra}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}
