using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_007_PointyTestClass
{
    class PitchFork : IPointy
    {
        public byte Points => throw new NotImplementedException();

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
