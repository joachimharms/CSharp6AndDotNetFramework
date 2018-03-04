using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_007_PointyTestClass
{
    class Fork : IPointy
    {
        // automatische Implementation des Interfaces durch das Quick Action Menü.
        public byte Points => throw new NotImplementedException();

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
