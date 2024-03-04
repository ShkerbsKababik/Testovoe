using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZadanie1.Figures
{
    public class Circle : IFigure
    {
        // Fields
        public double Square => CalculateSquare();
        public double Radius;

        // Ctor
        public Circle(double radius)
            => Radius = radius;

        // Methods
        private double CalculateSquare()
            => Math.PI * Math.Pow(Radius, 2);
    }
}
