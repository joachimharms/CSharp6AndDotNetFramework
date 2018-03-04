using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_006_ArrayOfInterfaceTypes
{
    // Circle DOES NOT override Draw().
    class Circle : Shape
    {
        public Circle() { }

        public Circle(string name) : base(name) { }

    }
}
