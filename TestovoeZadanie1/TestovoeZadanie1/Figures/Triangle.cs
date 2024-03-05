using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestovoeZadanie1.Exceptions;

namespace TestovoeZadanie1.Figures
{
    public class Triangle : IFigure
    {
        // Public fields
        public bool IsTriangleRight => CalculateRightTriangle();
        public double Square => CalculateSquare();
        public double A, B, C;

        // Private fields
        private double aSqure => Math.Pow(A, 2);
        private double bSqure => Math.Pow(B, 2);
        private double cSqure => Math.Pow(C, 2);

        // Ctor
        public Triangle(double aSide, double bSide, double cSide)
        {
            // Check data verification
            if(CheckIfSidesZero(aSide, bSide, cSide) || 
                CheckIfSidesTriangle(aSide, bSide, cSide))
                throw new InvalidInputDataException();

            A = aSide;
            B = bSide;
            C = cSide;
        }

        // Methods
        private double CalculateSquare()
        { 
            double halfP = (A + B + C) / 2;
            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }
        private bool CalculateRightTriangle() 
        {
            double hypotenuse = Math.Max(A, Math.Max(B, C));
            return Math.Pow(hypotenuse, 2) == aSqure + bSqure + cSqure - Math.Pow(hypotenuse, 2);
        }
        private bool CheckIfSidesZero(double a, double b, double c)
        {
            return a <= 0 || b <= 0 || c <= 0;
        }
        private bool CheckIfSidesTriangle(double a, double b, double c)
        {
            return a >= b + c || b >= a + c || c >= a + b;
        }
    }    
}
