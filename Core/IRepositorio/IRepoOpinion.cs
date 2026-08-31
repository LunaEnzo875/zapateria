using System;
using Core.Dto;
using Core.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.IRepositorio;
public interface IRepoOpinion
{
    IEnumerable<OpinionDto> GetOpinion();
    Opinion? DetalleOpinion(int dni);
}