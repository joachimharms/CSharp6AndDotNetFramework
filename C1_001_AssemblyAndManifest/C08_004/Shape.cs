using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_004
{
    // The abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }

        // A single virtual method.
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }

    }
}
