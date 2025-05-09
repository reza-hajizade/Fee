using Fee.Application.Interfaces;
using Fee.Domain.Enums;
using Fee.Endpoints.Contracts;

namespace Fee.Application.FeeStrategies
{
    public class BusBuyStrategy : IFeeCalculator
    {
        public bool IsMatch(VehicleType vehicleType, BuyOrSell buyOrSell)
        => vehicleType == VehicleType.Bus && buyOrSell == BuyOrSell.buy;

        public decimal CalculateFee(CalculateVehicleRequest request)
            => request.count * request.price * 0.0004m;
    }
}
