using System.Drawing;
using TestovoeZadanie1;
using TestovoeZadanie1.Figures;
using Xunit.Sdk;
using TestovoeZadanie1.Exceptions;

namespace TestovoeZadanie1Tests
{
    public class Tests
    {
        [Fact]
        public void CircleSqureTest1()
        {
            // Arrange
            double radius = 5;
            var circle = new Circle(radius);

            // Act
            var answer = Calculator.GetSquare(circle);

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radius, 2), answer);
        }
        [Fact]
        public void CircleSqureTest2()
        {
            // Assert
            Assert.ThrowsAny<InvalidInputDataException>(() => {
                // Arrange          
                double radius = -1;
                var circle = new Circle(radius);

                // Act
                var answer = Calculator.GetSquare(circle);
            });
        }
        [Fact]
        public void TriangleSqureTest1()
        {
            // Arrange
            double side = 2;
            var triangle = new Triangle(side, side, side);

            // Act
            var answer = Calculator.GetSquare(triangle);

            // Assert
            Assert.Equal(answer, 1.7320508075688772);
        }
        [Fact]
        public void TriangleSqureTest2()
        {           
            // Assert
            Assert.ThrowsAny<InvalidInputDataException>(() => {
                // Arrange
                double side = -2;
                var triangle = new Triangle(side, side, side);

                // Act
                var answer = Calculator.GetSquare(triangle);
            });
        }
        [Fact]
        public void TriangleRightTest1()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var answer = Calculator.IsTriangleRight(triangle);

            // Assert
            Assert.Equal(answer, true);
        }
    }
}