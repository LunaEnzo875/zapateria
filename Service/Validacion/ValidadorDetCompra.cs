using FluentValidation;
using Core.Dto;
using Core.IRepositorio;

namespace Service.Validacion;
public class ValidadorDetCompra : AbstractValidator<DetalleCompraDto>
{
    private readonly IRepoDetalleCompra _repositorioDetCompra;
    public ValidadorDetCompra(IRepoDetalleCompra repositorioDetCompra)
    {
        _repositorioDetCompra = repositorioDetCompra;

        RuleFor(x => x.numeroCompra)
            .NotEmpty().WithMessage("El numero de compra es obligatorio")
            .GreaterThan(0).WithMessage("El numero de compra debe ser mayor que 0");

        RuleFor(x => x.idModelo)
            .NotEmpty().WithMessage("El id del modelo es obligatorio")
            .GreaterThan(0).WithMessage("El id del modelo debe ser mayor que 0");

        RuleFor(x => x.talle)
            .NotEmpty().WithMessage("El talle es obligatorio")
            .GreaterThan(0).WithMessage("El talle debe ser mayor que 0");

        RuleFor(x => x.idZapatilla)
            .NotEmpty().WithMessage("El id de la zapatilla es obligatorio")
            .GreaterThan(0).WithMessage("El id de la zapatilla debe ser mayor que 0");

        RuleFor(x => x.precioUnitario)
            .NotEmpty().WithMessage("El precio unitario es obligatorio")
            .GreaterThan(0).WithMessage("El precio unitario debe ser mayor que 0");
            
        RuleFor(x => x.cantidad)
            .NotEmpty().WithMessage("La cantidad es obligatoria")
            .GreaterThan(0).WithMessage("La cantidad debe ser mayor que 0");
    }  
}
