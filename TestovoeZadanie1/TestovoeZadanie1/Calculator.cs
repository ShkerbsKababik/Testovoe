using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestovoeZadanie1.Figures;

namespace TestovoeZadanie1
{
    // так как рантайм происходит у клиента и он выбирает фигуру для просчета то данный код происходит не в компайл-тайм
    // надеюсь я понял вашу идею
    public static class Calculator
    {
        public static double GetSquare(IFigure figure)
            => figure.Square;
        public static bool IsTriangleRight(Triangle triangle)
            => triangle.IsTriangleRight;
    }
}
