using Fee.Application.Interfaces;
using Fee.Domain.Enums;
using Fee.Endpoints.Contracts;

namespace Fee.Application.FeeStrategies
{
    public class TruckBuyStrategy : IFeeCalculator
    {
        public bool IsMatch(VehicleType vehicleType, BuyOrSell buyOrSell)
       => vehicleType == VehicleType.Truck && buyOrSell == BuyOrSell.buy;

        public decimal CalculateFee(CalculateVehicleRequest request)
            => request.count * request.price * 0.0003m;
    }
}
