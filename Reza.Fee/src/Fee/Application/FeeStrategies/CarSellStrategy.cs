using Fee.Application.Interfaces;
using Fee.Domain.Enums;
using Fee.Endpoints.Contracts;

namespace Fee.Application.FeeStrategies
{
    public class CarSellStrategy : IFeeCalculator
    {
        public bool IsMatch(VehicleType vehicleType, BuyOrSell buyOrSell)
         => vehicleType == VehicleType.Car && buyOrSell == BuyOrSell.sell;

        public decimal CalculateFee(CalculateVehicleRequest request)
            => request.count * request.price * 0.0003m;
    }
}
