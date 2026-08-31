using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;
using ZapatosRepo;

namespace Repositorio;

    public class RepoZapatilla : Repo, IRepoZapatilla
    {
        private readonly IAdo _ado;

        public RepoZapatilla(IAdo _ado) : base(_ado)
        {
            this._ado = _ado;
        }

        private static readonly string _Zapatilla
        = "SELECT * FROM Zapatilla";
        public IEnumerable<ZapatillaDto> GetZapatillas()=>_conexion.Query<ZapatillaDto>(_Zapatilla);
        
         private static readonly string _queryDetalleZapatilla
        = @"SELECT * FROM Zapatilla WHERE idZapatilla = @idZapatilla";
        public Zapatilla? DetalleZapatilla(int idZapatilla)
        {
            return _conexion.QueryFirstOrDefault<Zapatilla>(_queryDetalleZapatilla, new { idZapatilla });
        }
    }
    
