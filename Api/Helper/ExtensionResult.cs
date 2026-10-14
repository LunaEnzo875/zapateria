using calzadosResult;
using Core.Entidades;
namespace calzadosExtension;

public static class ResultExtensions
{
    public static IResult ToMinimalResult<T>(this Result<T> result)
    {

        return result.ResultType switch
        {
            TiposResult.Ok => result.Ok(result.Data),
            TiposResult.Created => result.Created(string.Empty, result.Data),
            TiposResult.NotFound => result.NotFound(new { message = result.Message }),
            TiposResult.Unauthorized => result.Unauthorized(),
            TiposResult.Forbidden => result.StatusCode(StatusCodes.Status403Forbidden),
            TiposResult.Conflict => result.Conflict(new { message = result.Message }),
            TiposResult.BadRequest => result.Message is null ? result.BadRequest(new { error = result.Errors }) : Results.BadRequest(new { message = result.Message }),
            TiposResult.File => result.File(result.Bytes ?? Array.Empty<byte>()),
            TiposResult.Unprocessable_Entity => result.Unprocessable_Entity(new {message = result.Message}),
            _ => result.BadRequest(new { message = "Resultado no compatible" })
            
            
        };
    }
}