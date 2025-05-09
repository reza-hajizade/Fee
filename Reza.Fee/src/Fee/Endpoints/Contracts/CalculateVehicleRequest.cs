using Fee.Domain.Enums;
using FluentValidation;
using Microsoft.Extensions.Options;

namespace Fee.Endpoints.Contracts;

public sealed record CalculateVehicleRequest(
    VehicleType vehicleType,
    decimal price,
    int count,
    BuyOrSell buyOrSell
);





public sealed class CalculateVehicleRequestValidator : AbstractValidator<CalculateVehicleRequest>
{
    public CalculateVehicleRequestValidator()
    {
        RuleFor(x => x.vehicleType)
            .NotEmpty()
            .WithMessage("Vehicle type is required.")
            .IsInEnum()
            .WithMessage("Invalid vehicle type. Car=1 , Truck=2 and bus=3");
        RuleFor(x => x.price)
            .NotEmpty()
            .WithMessage("Price is required.")
            .GreaterThan(0)
            .WithMessage("Price must be greater than 0.");
        RuleFor(x => x.count)
            .NotEmpty()
            .WithMessage("Count is required.")
            .GreaterThan(0)
            .WithMessage("Count must be greater than 0.");
        RuleFor(x => x.buyOrSell)
            .NotEmpty()
            .WithMessage("Buy or Sell is required.")
            .IsInEnum()
            .WithMessage("Invalid Buy or Sell value. Buy=1 and Sell=2");

    }
  
}
