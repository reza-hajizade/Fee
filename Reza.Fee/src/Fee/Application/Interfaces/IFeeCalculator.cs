using System.Net;
using Fee.Domain.Enums;
using Fee.Endpoints.Contracts;

namespace Fee.Application.Interfaces
{
    // Defines a strategy for fee calculation based on vehicle type and transaction.
    public interface IFeeCalculator
    {
        bool IsMatch(VehicleType vehicleType, BuyOrSell buyOrSell);
        decimal CalculateFee(CalculateVehicleRequest createVehicle);
    }
}
