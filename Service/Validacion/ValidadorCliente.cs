using FluentValidation;
using Core.Dto;
using Core.IRepositorio;

namespace Service.Validacion;
public class ValidadorCliente : AbstractValidator<ClienteDto>
{
    private readonly IRepoCliente _repositorioCliente;
    public ValidadorCliente(IRepoCliente repositorioCliente)
    {
        _repositorioCliente = repositorioCliente;

        RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage("El nombre es obligatorio")
            .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres");

        RuleFor(x => x.apellido)
            .NotEmpty().WithMessage("El apellido es obligatorio")
            .MaximumLength(50).WithMessage("El apellido no puede tener más de 50 caracteres");
        RuleFor(x => x.idCliente)
            .Cascade(CascadeMode.Stop)
            .GreaterThan(0).WithMessage("El idCliente debe ser mayor que 0")
            .MustAsync(async (idCliente, cancellationToken) =>
                await _repositorioCliente.ObtenerPorIdAsync(idCliente, cancellationToken) is null)
            .WithMessage("El idCliente ya existe en la base de datos");
    }
}

