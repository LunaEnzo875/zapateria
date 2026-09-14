using Core.Entidades;
using Core.IService;

namespace Api.Endpoints;

public static class EndpointsDevolucion
{
    public static void MapEndpointsDevolucion(this WebApplication app)
    {
        app.MapGet("/devoluciones", (IDevolucionService service) =>
        {
            var resultado = service.GetDevolucion();
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapGet("/devoluciones/{idDevolucion:int}", (int idDevolucion, IDevolucionService service) =>
        {
            var resultado = service.DetalleDevolucion(idDevolucion);
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapPost("/devoluciones", (Devolucion devolucion, IDevolucionService service) =>
        {
            var resultado = service.AltaDevolucion(devolucion);
            return resultado.Success
                ? Results.Created($"/devoluciones/{resultado.Data!.idDevolucion}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}