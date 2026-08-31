using System;
using Core.Entidades;
using Core.Dto;
namespace Core.IRepositorio;

    public interface IRepoZapatilla
    {
        IEnumerable<ZapatillaDto> GetZapatillas();
        Zapatilla? DetalleZapatilla(int idZapatilla);
    }
