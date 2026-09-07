using System;
using Core.Dto;
using Core.Entidades;

namespace Core.IService;

    public interface IFabricanteService
{
    Result<IEnumerable<FabricanteDto>> GetFabricante();
    Result<FabricanteDto> AltaFabricante();
}
