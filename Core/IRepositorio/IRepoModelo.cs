using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoModelo
{
    IEnumerable<ModeloDto> GetModelo();
    ModeloDto? DetalleModelo(int idModelo);
    void AltaModelo(ModeloDto modelo);
}