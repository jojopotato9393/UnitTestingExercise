using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 1, 1, 3)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-1, 1, 1, 1)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

           var actual = calculator.Add(num1, num2, num3);

            Assert.Equal(actual, expected);

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,8)]//Add test data <-------
        [InlineData(4,4,0)]//Add test data <-------
        [InlineData(2,4,-2)]//Add test data <-------
        [InlineData(-2,-4,2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            Calculator sub = new Calculator();

            //Arrange
            var actual = sub.Sub(minuend, subtrhend);

            //Act
            Assert.Equal(actual, expected);
            //Assert

        }

        [Theory]
        [InlineData(1,5,5)]//Add test data <-------
        [InlineData(2,2,4)]//Add test data <-------
        [InlineData(-2,4,-8)]//Add test data <-------
        [InlineData(-2,-4,8)]//Add test data <-------

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            Calculator mul = new Calculator();
            //Arrange
            int actual = mul.Mul(num1, num2);
            //Act
            Assert.Equal(actual, expected);
            //Assert

        }

        [Theory]
        [InlineData(4,2,2)]//Add test data <-------
        [InlineData(1,1,1)]//Add test data <-------
        [InlineData(-4,-2,2)]//Add test data <-------
        [InlineData(4,-2,-2)]//Add test data <-------
        [InlineData(4,1,4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator div = new Calculator();

            //Act
           int actual = div.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

    }
}
