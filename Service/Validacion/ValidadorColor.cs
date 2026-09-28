using FluentValidation;
using Core.Dto;
using Core.IRepositorio;

namespace Service.Validacion;
public class ValidadorColor : AbstractValidator<ColorDto>
{
    private readonly IRepoColor _repositorioColor;
    public ValidadorColor(IRepoColor repositorioColor)
    {
        _repositorioColor = repositorioColor;

        RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage("El nombre es obligatorio")
            .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres");
        RuleFor(x => x.idColor)
            .Cascade(CascadeMode.Stop)
            .GreaterThan(0).WithMessage("El idColor debe ser mayor que 0")
            .Must(idColor => _repositorioColor.DetalleColor(idColor) is null)
            .WithMessage("El idColor ya existe en la base de datos");
    }
}
