using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestovoeZadanie1.Figures;

namespace TestovoeZadanie1
{
    public class Calculator
    {
        public double GetSquare(IFigure figure)
            => figure.Square;
        public bool IsTriangleRight(Triangle triangle)
            => triangle.IsTriangleRight;
    }
}
