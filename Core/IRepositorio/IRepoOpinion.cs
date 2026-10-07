using Core.Dto;
using Core.Entidades;

namespace Core.IRepositorio;
public interface IRepoOpinion
{
    IEnumerable<OpinionDto> GetOpinion();
    Opinion? DetalleOpinion(int dni);
    bool ExisteModelo(int idModelo);
    bool ExisteCliente(int dni);
    bool ClienteComproModelo(int dni, int idModelo);
    bool ExisteOpinion(int idModelo, DateTime fechaHora, int dni);
    void AltaOpinion(Opinion opinion);
}