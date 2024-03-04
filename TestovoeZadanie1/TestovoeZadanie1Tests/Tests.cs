using TestovoeZadanie1;
using TestovoeZadanie1.Figures;

namespace TestovoeZadanie1Tests
{
    public class Tests
    {
        [Fact]
        public void CircleSqureTest1()
        {
            // Arrange          
            var circle = new Circle(5);

            // Act
            var answer = Calculator.GetSquare(circle);

            // Assert
            Assert.Equal(answer, Math.PI * Math.Pow(5, 2));
        }
    }
}