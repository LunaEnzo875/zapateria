using Core.Entidades;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointsDetalleCompra
{
    public static void MapEndpointsDetalleCompra(this WebApplication app)
    {
        app.MapGet("/detalleCompra", (IDetallleCompraService service) =>
        {
            var resultado = service.GetDetallleCompra();
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapGet("/detalleCompra/{numeroCompra:int}", (int numeroCompra, IDetallleCompraService service) =>
        {
            var resultado = service.GetDetallleCompra();
            var detalle = resultado.Data?.FirstOrDefault(x => x.numeroCompra == numeroCompra);

            return detalle is not null
                ? Results.Ok(detalle)
                : Results.NotFound();
        });

        app.MapPost("/detalleCompra", (DetalleCompra detalleCompra, IDetallleCompraService service) =>
        {
            var resultado = service.AltaDetallleCompra(detalleCompra);
            return resultado.Success
                ? Results.Created($"/detalleCompra/{resultado.Data!.numeroCompra}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}
