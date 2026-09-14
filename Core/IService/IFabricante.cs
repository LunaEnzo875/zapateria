using Core.Dto;
using Core.Entidades;

namespace calzadosIService;

public interface IFabricanteService
{
    Result<IEnumerable<FabricanteDto>> GetFabricante();
    Result<FabricanteDto> DetalleFabricante(int idFabricante);
    Result<FabricanteDto> AltaFabricante(Fabricante fabricante);
}
