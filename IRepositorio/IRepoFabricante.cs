namespace ZapatosRepo;

public interface IRepoFabricante
{
    IEnumerable<FabricanteDto> GetFabricante();
    Fabricante? Fabricante(int idFabricante);
}