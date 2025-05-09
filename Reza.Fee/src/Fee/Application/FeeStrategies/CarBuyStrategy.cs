using Fee.Application.Interfaces;
using Fee.Domain.Enums;
using Fee.Endpoints.Contracts;

namespace Fee.Application.FeeStrategies
{
    public class CarBuyStrategy : IFeeCalculator
    {

        public bool IsMatch(VehicleType vehicleType, BuyOrSell buyOrSell)
         => vehicleType == VehicleType.Car && buyOrSell == BuyOrSell.buy;

        public decimal CalculateFee(CalculateVehicleRequest request)
            => request.count * request.price * 0.0002m;
    }
}
