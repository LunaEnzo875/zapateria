using FluentValidation;
using Core.Dto;
using Core.IRepositorio;
using System.Data;


namespace Service.Validacion;
public class ValidadorOpinion : AbstractValidator<OpinionDto>
{
    private readonly IRepoOpinion _repoOpinion;
    
    public ValidadorOpinion (IRepoOpinion repoOpinion )
    {
        _repoOpinion = repoOpinion;

        RuleFor(p => p.descripcion)
        .MaximumLength(450).WithMessage("El nombre debe tener como máximo 450 caracteres.");
    
        RuleFor(p => p.fechaHora)
        .NotEmpty().WithMessage("La fecha es obligatoria.")
        .Must(date => date > DateTime.UtcNow).WithMessage("La fecha de la funcion debe ser posterior a la fecha actual.");
    }
}
