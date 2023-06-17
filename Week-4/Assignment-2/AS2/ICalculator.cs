using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS2;

namespace AS2
{
    public interface ICalculator
    {
        public int Add(int a, int b);
        public int Subtract(int a, int b);
    }

    public class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public class AdvancedCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return (a + b) / 2;
        }

        public int Subtract(int a, int b)
        {
            return ((a - b) / 2);
        }
    }

    
}
