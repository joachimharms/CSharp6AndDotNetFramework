using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_004
{
    // This struct implicitly derives from System.ValueType and
    // implements two interfaces.
    public struct PitchFork : ICloneable, IPointy
    {
        public byte Points => throw new NotImplementedException();

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }


}
