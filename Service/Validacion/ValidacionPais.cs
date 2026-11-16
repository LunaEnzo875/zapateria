using FluentValidation;
using Core.Dto;
using Core.IRepositorio;
using System.Data;

namespace Service.Validacion;
public class ValidacionPais : AbstractValidator<PaisDto>
{
    private readonly IRepoPais _repoPais;

    public ValidacionPais (IRepoPais repoPais)
    {
        _repoPais = repoPais;

        RuleFor(z => z.idPais)
        .Cascade(CascadeMode.Stop)
            .GreaterThan(0).WithMessage("El idModelo debe ser mayor que 0")
            .Must(idPais => _repoPais.DetallePais(idPais) is null).WithMessage("El usuario referenciado no existe.")
            .WithMessage("El idModelo ya existe en la base de datos")
            .Must(idPais => _repoPais.DetallePais(idPais) is null).WithMessage("Ya existe un cliente creado bajo ese usuario.");

        RuleFor(z => z.Nombre)
        .NotEmpty().WithMessage("El nombre es obligatorio")
        .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres.")
        .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres");

    }
}
