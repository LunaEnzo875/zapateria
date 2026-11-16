using FluentValidation;
using Core.Dto;
using Core.IRepositorio;

namespace Service.Validacion;

public class ValidadorModelo : AbstractValidator<ModeloDto>
{
    private readonly IRepoModelo _repositorioModelo;
    public ValidadorModelo (IRepoModelo repositorioModelo)
    {
        _repositorioModelo = repositorioModelo;

        RuleFor(x => x.idModelo)
        .Cascade(CascadeMode.Stop)
            .GreaterThan(0).WithMessage("El idModelo debe ser mayor que 0")
            .Must(idModelo => _repositorioModelo.DetalleModelo(idModelo) is null).WithMessage("El usuario referenciado no existe.")
            .WithMessage("El idModelo ya existe en la base de datos");
        
        RuleFor(x => x.idFabricante)
        .Cascade(CascadeMode.Stop)
            .GreaterThan(0).WithMessage("El idModelo debe ser mayor que 0")
            .WithMessage("El idModelo ya existe en la base de datos");

        RuleFor(z => z.Nombre)
        .NotEmpty().WithMessage("El nombre es obligatorio")
        .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres.")
        .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres");
    }

}
