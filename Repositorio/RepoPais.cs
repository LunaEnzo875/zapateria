using System;
using Core.Dto;
using Core.Entidades;
using Core.IRepositorio;
using Core.IService;
using Dapper;
using ZapatosRepo;

namespace Repositorio
{
public class RepoPais :Repo, IRepoPais
    {
        private readonly IAdo _ado;

        public RepoPais(IAdo _ado) : base(_ado)
        {
            this._ado = _ado;
        }
        public IEnumerable<PaisDto> GetPaises()
        {
            return _conexion.Query<PaisDto>(_Pais);
        }

        private static readonly string _Pais
        = "SELECT * FROM Pais";
        IEnumerable<PaisDto> IRepoPais.GetPaises() => _conexion.Query<PaisDto>(_Pais);


        private static readonly string _queryDetallePais
            = @"SELECT * FROM Pais WHERE idPais = @idPais";
        public Pais? DetallePais(int idPais)
        {
            return _conexion.QueryFirstOrDefault<Pais>(_queryDetallePais, new { idPais });
        }
    }
}
