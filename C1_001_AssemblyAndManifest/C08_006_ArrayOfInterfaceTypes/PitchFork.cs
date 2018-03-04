using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_006_ArrayOfInterfaceTypes
{
    class PitchFork : IPointy
    {
        public byte Points
        {
            get { return 3; }
        }

        public byte GetNumberOfPoints()
        {
            return 3;
        }
    }
}
