using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoFabricante
{
    IEnumerable<FabricanteDto> GetFabricante();
    FabricanteDto? DetalleFabricante(int idFabricante);
    void AltaFabricante(FabricanteDto fabricante);
}