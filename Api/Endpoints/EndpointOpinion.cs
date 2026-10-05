using System.Globalization;
using System.Text.Json.Serialization;
using Core.Entidades;
using calzadosIService;

namespace Api.Endpoints;

public static class EndpointOpinion
{
    public static void MapEndpointsOpinion(this WebApplication app)
    {
        app.MapPost("/modelos/{id:int}/opiniones", (int id, CrearOpinionRequest request, IOpinionServie service) =>
        {
            if (!int.TryParse(request.ClienteDni, NumberStyles.None, CultureInfo.InvariantCulture, out var dni))
                return Results.BadRequest(new { message = "cliente_dni debe ser un DNI numérico" });

            var opinion = new Opinion(dni, id, DateTime.Now, request.Descripcion ?? string.Empty, request.Nota);
            var resultado = service.AltaOpinion(opinion);

            return resultado.ResultType switch
            {
                calzadosResult.TiposResult.Created => Results.Created(
                    $"/modelos/{id}/opiniones/{dni}/{resultado.Data!.fechaHora:O}", resultado.Data),
                calzadosResult.TiposResult.NotFound => Results.NotFound(new { message = resultado.Message }),
                calzadosResult.TiposResult.Forbidden => Results.StatusCode(StatusCodes.Status403Forbidden),
                calzadosResult.TiposResult.Conflict => Results.Conflict(new { message = resultado.Message }),
                _ => Results.BadRequest(new { message = resultado.Message })
            };
        });
    }
}

public sealed class CrearOpinionRequest
{
    [JsonRequired]
    [JsonPropertyName("cliente_dni")]
    public string? ClienteDni { get; set; }

    [JsonRequired]
    [JsonPropertyName("descripcion")]
    public string? Descripcion { get; set; }

    [JsonRequired]
    [JsonPropertyName("nota")]
    public decimal Nota { get; set; }
}
