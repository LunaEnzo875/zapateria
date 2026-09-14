using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using calzadosIService;

namespace ServiceZapatos;

public class ServiceFabricante : IFabricanteService
{
    readonly IRepoFabricante _repoFabricante;

    public ServiceFabricante(IRepoFabricante repoFabricante)
    {
        _repoFabricante = repoFabricante;
    }

    public Result<IEnumerable<FabricanteDto>> GetFabricante() => Result<IEnumerable<FabricanteDto>>.Ok(_repoFabricante.GetFabricante());

    public Result<FabricanteDto> DetalleFabricante(int idFabricante)
    {
        var fabricante = _repoFabricante.DetalleFabricante(idFabricante);
        return fabricante is null
            ? Result<FabricanteDto>.NotFound($"No se encontró el fabricante con id {idFabricante}")
            : Result<FabricanteDto>.Ok(fabricante);
    }

    public Result<FabricanteDto> AltaFabricante(Fabricante fabricante)
    {
        var nuevoFabricante = new FabricanteDto
        {
            idFabricante = fabricante.idFabricante,
            NombreFab = fabricante.NombreFab,
        };

        _repoFabricante.AltaFabricante(nuevoFabricante);
        return Result<FabricanteDto>.Created(nuevoFabricante);
    }
}
