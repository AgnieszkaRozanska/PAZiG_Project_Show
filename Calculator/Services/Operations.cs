using Calculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
