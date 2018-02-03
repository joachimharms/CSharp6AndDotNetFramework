using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_007_SealedVirtualMethods
{
    public class OuterClass
    {
        // A public nested type can be used by anybody.
        public class PublicInnerClass { }
        // A private nested type can only be used by members
        // of the containing class.
        private class PrivateInnerClass { }
    }
}
