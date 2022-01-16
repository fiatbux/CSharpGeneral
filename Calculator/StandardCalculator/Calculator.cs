using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    public class Calculator : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
