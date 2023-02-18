using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Calculations
    {
        public double AddNumbers(double x, double y)
        {
            double output = x + y;
            return output;
        }

        public double MultiplyNumbers(double x, double y)
        {
            double output = x * y;
            return output;
        }

        public double SubtractNumbers(double x, double y)
        {
            double output = x - y;
            return output;
        }

        public double DivideNumbers(double x, double y)
        {
            double output = 0;
            if (y != 0)
            {
                output = x / y;
            }
            return output;
        }
    }
}
