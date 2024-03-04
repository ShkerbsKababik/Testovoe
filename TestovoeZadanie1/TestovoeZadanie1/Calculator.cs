using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestovoeZadanie1.Figures;

namespace TestovoeZadanie1
{
    public static class Calculator
    {
        public static double GetSquare(IFigure figure)
            => figure.Square;
        public static bool IsTriangleRight(Triangle triangle)
            => triangle.IsTriangleRight;
    }
}
