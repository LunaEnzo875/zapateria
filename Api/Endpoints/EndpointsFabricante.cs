using Core.Entidades;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointsFabricante
{
    public static void MapEndpointsFabricante(this WebApplication app)
    {
        app.MapGet("/fabricantes", (IFabricanteService service) =>
        {
            var resultado = service.GetFabricante();
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapGet("/fabricantes/{idFabricante:int}", (int idFabricante, IFabricanteService service) =>
        {
            var resultado = service.DetalleFabricante(idFabricante);
            return resultado.Success
                ? Results.Ok(resultado.Data)
                : Results.NotFound(resultado);
        });

        app.MapPost("/fabricantes", (Fabricante fabricante, IFabricanteService service) =>
        {
            var resultado = service.AltaFabricante(fabricante);
            return resultado.Success
                ? Results.Created($"/fabricantes/{resultado.Data!.idFabricante}", resultado.Data)
                : Results.BadRequest(resultado);
        });
    }
}
