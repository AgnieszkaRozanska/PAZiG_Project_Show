using Calculator.Services.Interfaces;

namespace Calculator.Services
{
    internal class Operations : IOperations
    {
        public double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
