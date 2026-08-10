namespace ZapatosRepo;

public interface IRepoModelo
{
    IEnumerable<Modelo> GetModelo();
    Modelo? Modelo(int idModelo);
}