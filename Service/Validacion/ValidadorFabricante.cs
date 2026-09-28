using FluentValidation;
using Core.Dto;
using Core.IRepositorio;

namespace Service.Validacion;
public class ValidadorFabricante : AbstractValidator<FabricanteDto>
{
    private readonly IRepoFabricante _repositorioFabricante;
    public ValidadorFabricante(IRepoFabricante repositorioFabricante)
    {
        _repositorioFabricante = repositorioFabricante;

        RuleFor(x => x.NombreFab)
            .NotEmpty().WithMessage("El nombre es obligatorio")
            .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres");
        
        RuleFor(x => x.idFabricante)
            .Cascade(CascadeMode.Stop)
            .GreaterThan(0).WithMessage("El idFabricante debe ser mayor que 0")
            .MustAsync(async (idFabricante, cancellationToken) =>
                await _repositorioFabricante.ObtenerPorIdAsync(idFabricante, cancellationToken) is null)
            .WithMessage("El idFabricante ya existe en la base de datos");
    } 
}
