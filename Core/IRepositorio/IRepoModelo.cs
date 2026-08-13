using Core.Dto;
using Core.Entidades;
namespace Core.IRepositorio;

public interface IRepoModelo
{
    IEnumerable<Modelo> GetModelo();
    Modelo? Modelo(int idModelo);
}