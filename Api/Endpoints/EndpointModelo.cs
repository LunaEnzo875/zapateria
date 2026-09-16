using Core.Entidades;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointsModelo
{
    public static void MapEndpointsModelo(this WebApplication app)
    {
        app.MapGet("/modelos", (IModeloService service) =>
        {
            var resultado = service.GetModelo();
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapGet("/modelos/{idModelo:int}", (int idModelo, IModeloService service) =>
        {
            var resultado = service.DetalleModelo(idModelo);
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapPost("/modelos", (Modelo modelo, IModeloService service) =>
        {
            var resultado = service.AltaModelo(modelo);
            return resultado.Success
                ? Results.Created($"/modelos/{resultado.Data!.idModelo}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}
