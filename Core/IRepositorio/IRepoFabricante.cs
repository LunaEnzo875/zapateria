using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoFabricante
{
    IEnumerable<FabricanteDto> GetFabricante();
    FabricanteDto? DetalleFabricante(int idFabricante);
    Task<FabricanteDto?> ObtenerPorIdAsync(int idFabricante, CancellationToken cancellationToken = default);
    void AltaFabricante(FabricanteDto fabricante);
}