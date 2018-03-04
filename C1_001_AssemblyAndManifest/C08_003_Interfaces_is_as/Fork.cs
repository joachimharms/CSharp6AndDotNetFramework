using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_003_Interfaces_is_as
{
    // This class derives from a custom base class
    // and implements a single interface.
    class Fork : Utensil, IPointy
    {
        public byte Points => throw new NotImplementedException();

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
