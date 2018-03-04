using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_005_InterfacesAsReturnValues
{
    // ThreeDCircle supports IDraw3D.
    class ThreeDCircle : Circle, IDraw3D
    {
        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3 D");
        }
    }
}
