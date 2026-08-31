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
        public IEnumerable<OpinionDto> GetOpinion()
        {
            throw new NotImplementedException();
        }

        private static readonly string _Opinion
        = "SELECT * FROM Opinion";

        public IEnumerable<OpinionDto> GetOpinions() => _conexion.Query<OpinionDto>(_Opinion);

        private static readonly string _DetalleOpinion 
        = @"SELECT * FROM Opinion WHERE DNI = @DNI";

        public Opinion? DetalleOpinion(int dni)
        {
            return _conexion.QueryFirstOrDefault<Opinion>(_DetalleOpinion, new { dni });
        }
    }
}