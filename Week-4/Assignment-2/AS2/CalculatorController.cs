using System;

namespace AS2
{
    public class CalculatorController
    {
            private readonly ICalculator _cal;
            private string _calculatorType;

            public CalculatorController(ICalculator cal, string CalculatorType)
            {
                _cal = cal;
                _calculatorType = CalculatorType;
            }

            public int Calculate(int a, int b)
            {
                if(_calculatorType == "+")
                {
                    return _cal.Add(a,b);
                }
                else if(_calculatorType == "-")
                {
                    return _cal.Subtract(a,b);
                }
                else
                {
                    throw new InvalidOperationException("Invalid calculator type");
                }
        }
    }
}

