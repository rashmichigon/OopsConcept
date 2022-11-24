using OopsConcept.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism
{
    abstract class Shape
    {
        public abstract int area();

        public static implicit operator Shape(Square v)
        {
            throw new NotImplementedException();
        }
    }
}
