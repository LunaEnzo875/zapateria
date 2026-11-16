using FluentValidation;
using Core.Dto;
using Core.IRepositorio;
using System.Data;

namespace Service.Validacion;

    public class ValidadorZapatilla : AbstractValidator<ZapatillaDto>
    {
        private readonly IRepoZapatilla _repoZapatilla;
        public ValidadorZapatilla(IRepoZapatilla repoZapatilla)
        {
        
        }
    }
