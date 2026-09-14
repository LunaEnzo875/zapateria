using Core.Entidades;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointsColor
{
    public static void MapEndpointsColor(this WebApplication app)
    {
        app.MapGet("/colores", (IColorService service) =>
        {
            var resultado = service.GetColor();
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapGet("/colores/{idColor:int}", (int idColor, IColorService service) =>
        {
            var resultado = service.DetalleColor(idColor);
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapPost("/colores", (Color color, IColorService service) =>
        {
            var resultado = service.AltaColor(color);
            return resultado.Success
                ? Results.Created($"/colores/{resultado.Data!.idColor}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}
