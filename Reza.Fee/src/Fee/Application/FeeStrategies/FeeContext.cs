using Fee.Application.Interfaces;
using Fee.Endpoints.Contracts;

namespace Fee.Application.FeeStrategies
{
    // محاسبه کارمزد با استفاده از الگوی طراحی Strategy 

    public class FeeContext
    {
        private readonly IEnumerable<IFeeCalculator> _feeCalculators;

        public FeeContext(IEnumerable<IFeeCalculator> feeCalculators)
        {
            _feeCalculators = feeCalculators;
        }

        public decimal CalculateFee(CalculateVehicleRequest createVehicle)
        {
            var calculator = _feeCalculators.FirstOrDefault(c => c.IsMatch(createVehicle.vehicleType, createVehicle.buyOrSell));
            if (calculator == null)
            {
                throw new InvalidOperationException("No suitable fee calculator found.");
            }
            return calculator.CalculateFee(createVehicle);
        }
    }
}
