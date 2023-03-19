using Calculator.Services.Interfaces;

namespace Calculator.Services
{
    internal class Operations : IOperations
    {
        public double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public double Subtraction(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
