using calzadosResult;
using Core.Entidades;
namespace calzadosExtension;

public static class ResultExtensions
{
    public static IResult ToMinimalResult<T>(this Result<T> result)
    {

        return result.ResultType switch
        {
            TiposResult.Ok => Results.Ok(result.Data),
            TiposResult.Created => Results.Created(string.Empty, result.Data),
            TiposResult.NotFound => Results.NotFound(new { message = result.Message }),
            TiposResult.Unauthorized => Results.Unauthorized(),
            TiposResult.BadRequest => result.Message is null ? Results.BadRequest(new { error = result.Errors }) : Results.BadRequest(new { message = result.Message })
        };
    }
}