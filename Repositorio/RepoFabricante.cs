using Core.IService;
namespace ZapatosRepo;

public class RepoFabricante
{
    private readonly IAdo _ado;
    private static string _Fabricante
    = "SELECT * FROM fabricante";
}