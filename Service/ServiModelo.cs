using Core.Entidades;
using Core.Dto;
using Core.IRepositorio;
using calzadosIService;

namespace ServiceZapatos;

public class ServiModelo : IModeloService
{
    readonly IRepoModelo _IModelo;
    public Result<IEnumerable<ModeloDto>> GetModelo()
    {
        throw new NotImplementedException();
    }
    public Result<ModeloDto> AltaModelo(Modelo modelo)
    {
        throw new NotImplementedException();
    }

    public Result<IEnumerable<Modelo>> GetColor() => Result<IEnumerable<ModeloDto>>.Ok(_IModelo.GetModelo);



}