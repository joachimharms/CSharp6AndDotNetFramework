using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_008_Shapes
{
    // Circle DOES NOT override Draw().
    class Circle : Shape
    {
        public Circle() { }

        public Circle(string name) : base(name) { }

    }
}
