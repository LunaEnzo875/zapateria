using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;
using ZapatosRepo;

namespace Repositorio
{
    public class RepoOpinion : Repo, IRepoOpinion
    {
        private readonly IAdo _ado;
        public RepoOpinion(IAdo _ado) : base(_ado)
        {
            this._ado = _ado;
        }
    
        private static readonly string _Opinion
        = "SELECT * FROM Opinion";

        public IEnumerable<OpinionDto> GetOpinion() => _conexion.Query<OpinionDto>(_Opinion);

        private static readonly string _DetalleOpinion 
        = @"SELECT * FROM Opinion WHERE DNI = @DNI";

        public Opinion? DetalleOpinion(int dni)
        {
            return _conexion.QueryFirstOrDefault<Opinion>(_DetalleOpinion, new { dni });
        }

        public bool ExisteModelo(int idModelo) => _conexion.QuerySingle<bool>(
            "SELECT EXISTS (SELECT 1 FROM Modelo WHERE idModelo = @idModelo)", new { idModelo });

        public bool ExisteCliente(int dni) => _conexion.QuerySingle<bool>(
            "SELECT EXISTS (SELECT 1 FROM Cliente WHERE dni = @dni)", new { dni });

        public bool ClienteComproModelo(int dni, int idModelo) => _conexion.QuerySingle<bool>(@"
            SELECT EXISTS (
                SELECT 1
                FROM Compra c
                INNER JOIN DetalleCompra dc ON dc.numeroCompra = c.numeroCompra
                WHERE c.dni = @dni AND dc.idModelo = @idModelo
            )", new { dni, idModelo });

        public bool ExisteOpinion(int idModelo, DateTime fechaHora, int dni) => _conexion.QuerySingle<bool>(@"
            SELECT EXISTS (
                SELECT 1 FROM Opinion
                WHERE idModelo = @idModelo AND fechaHora = @fechaHora AND dni = @dni
            )", new { idModelo, fechaHora, dni });

        public void AltaOpinion(Opinion opinion) => _conexion.Execute(@"
            INSERT INTO Opinion (dni, idModelo, fechaHora, descripcion, puntaje)
            VALUES (@dni, @idModelo, @fechaHora, @descripcion, @puntaje)", opinion);


        private static  readonly string _RakingPuntaje
        = "Select *,Count(Opiniones), IdPais, AVG(puntaje) from Opinion where idFabricante = idFabricante and Pais.nombre = Pais.nombre ";

        public Opinion? RankingOpinion(Opinion opinion, FabricanteDto fabricanteDto, Pais pais) 
        { 
            return _conexion.QueryFirst<Opinion>(_RakingPuntaje, new {opinion, fabricanteDto, pais});
        }
}
}