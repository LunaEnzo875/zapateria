using calzadosResult;
using Core.Dto;

namespace Core.Entidades;

public class Result<T>
{
    public bool Success { get; private set; }
    public T? Data { get; private set; }
    public string? Message { get; private set; }
    public TiposResult ResultType { get; private set; }
    public IDictionary<string, string[]>? Errors { get; private set; }
    public byte[]? Bytes { get; private set; }

    private Result( bool success, TiposResult resultType, T? data = default, string? message = null, IDictionary<string, string[]>? errors = null, byte[]? bytes = null)
    {
        Success = success;
        ResultType = resultType;
        Data = data;
        Message = message;
        Errors = errors;
        Bytes = bytes;
    }

    public static Result<T> Ok(T? data = default, string? message = null)
    => new(true, TiposResult.Ok, data, message);
    
    public static Result<T> Created(T data, string? message = null)
        => new(true, TiposResult.Created, data, message);

    public static Result<T> NotFound(string message)
        => new(false, TiposResult.NotFound, default, message);

    public static Result<T> Unauthorized()
        => new(false, TiposResult.Unauthorized, default, default, default);

    public static Result<T> BadRequest(IDictionary<string, string[]> errors = default, string? message = default)
        => new(false, TiposResult.BadRequest, default, message, errors);
    
    public static Result<T> File(byte[]? bytes)
        => new(true, TiposResult.File, default, default, default, bytes);

    public static Result<IEnumerable<Modelo>> Ok(IEnumerable<Modelo> enumerable)
    {
        throw new NotImplementedException();
    }

    public static Result<IEnumerable<Modelo>> Ok(Func<IEnumerable<Modelo>> getModelo)
    {
        throw new NotImplementedException();
    }

    public static Result<IEnumerable<RazonDevolucion>> Ok(IEnumerable<DevolucionDto> enumerable)
    {
        throw new NotImplementedException();
    }
}