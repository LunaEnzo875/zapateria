using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;

namespace ZapatosRepo;

public class RepoFabricante : Repo, IRepoFabricante
{
    private readonly IAdo _ado;

    public RepoFabricante(IAdo _ado) : base(_ado)
    {
        this._ado = _ado;
    }

    private static readonly string _altaFabricante = @"INSERT INTO Fabricante (idFabricante, NombreFab)
    VALUES (@idFabricante, @NombreFab);";

    public void AltaFabricante(FabricanteDto fabricante)
    {
        _conexion.Execute(_altaFabricante, new { fabricante.idFabricante, fabricante.NombreFab });
    }

    private static readonly string _detalleFabricante = "SELECT * FROM Fabricante WHERE idFabricante = @idFabricante";

    public FabricanteDto? DetalleFabricante(int idFabricante)
    {
        return _conexion.QueryFirstOrDefault<FabricanteDto>(_detalleFabricante, new { idFabricante });
    }

    private static readonly string _fabricante = "SELECT * FROM Fabricante";

    public IEnumerable<FabricanteDto> GetFabricante() => _conexion.Query<FabricanteDto>(_fabricante);
}