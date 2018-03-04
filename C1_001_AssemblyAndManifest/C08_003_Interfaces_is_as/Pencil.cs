using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_003_Interfaces_is_as
{
    // This class derives from System.Object and
    // implements a single interface.
    class Pencil : IPointy
    {
        public byte Points => throw new NotImplementedException();

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
