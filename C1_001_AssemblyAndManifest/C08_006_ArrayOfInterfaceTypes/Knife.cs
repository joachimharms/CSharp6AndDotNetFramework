using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_006_ArrayOfInterfaceTypes
{
    class Knife : IPointy
    {
        public byte Points
        {
            get { return 1; }
        }

        public byte GetNumberOfPoints()
        {
            return 1;
        }
    }
}
