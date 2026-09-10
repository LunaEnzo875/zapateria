using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoFabricante
{
    IEnumerable<FabricanteDto> GetFabricante();
    Fabricante? DetalleFabricante(int idFabricante);
}