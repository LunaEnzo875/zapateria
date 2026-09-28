using FluentValidation;
using Core.Dto;
using Core.IRepositorio;

namespace Service.Validacion;
public class ValidadorDevolucion : AbstractValidator<DevolucionDto>
{
    private readonly IRepoDevolucion _repositorioDevolucion;
    public ValidadorDevolucion(IRepoDevolucion repositorioDevolucion)
    {
        _repositorioDevolucion = repositorioDevolucion;

        RuleFor(x => x.idDevolucion)
            .NotEmpty().WithMessage("El idDevolucion es obligatorio")
            .GreaterThan(0).WithMessage("El idDevolucion debe ser mayor que 0");
        RuleFor(x => x.fechaHora)
            .NotEmpty().WithMessage("La fecha es obligatoria")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("La fecha no puede ser futura");
    }
}
