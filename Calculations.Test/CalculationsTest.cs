using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    public class CalculationsTest
    {
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(0,0,0)]
        [InlineData(5476, 3546, 9022)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations calculations = new Calculations();

            //Act
            double actual = calculations.AddNumbers(x, y);

            // Assert 
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12,8,4)]
        [InlineData(10, 5, 5)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            Calculations calculations = new Calculations();

            double actual = calculations.SubtractNumbers(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 8, 64)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            Calculations calculations = new Calculations();

            double actual = calculations.MultiplyNumbers(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 2, 25)]
        [InlineData(50, 0, 0)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            Calculations calculations = new Calculations();

            double actual = calculations.DivideNumbers(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
