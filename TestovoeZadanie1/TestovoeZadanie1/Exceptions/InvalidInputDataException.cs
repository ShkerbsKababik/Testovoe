using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZadanie1.Exceptions
{
    public class InvalidInputDataException : Exception
    {
        public InvalidInputDataException() : 
            base("the input you tried to enter when creating the figure was entered incorrectly") 
        { }
    }
}
