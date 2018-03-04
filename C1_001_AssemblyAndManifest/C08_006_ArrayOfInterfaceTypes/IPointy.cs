using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_006_ArrayOfInterfaceTypes
{
    // This interface defines the behavior of "having points."
    interface IPointy
    {
        //// Error! Interfaces cannot have data fields!
        //public int numbOfPoints;
        //// Error! Interfaces do not have constructors!
        //public IPointy() { numbOfPoints = 0; }
        //// Error! Interfaces don't provide an implementation of members!
        //byte GetNumberOfPoints() { return numbOfPoints; }

        // A read-write property in an interface would look like:
        // retType PropName { get; set; }
        //
        // while a write-only property in an interface would be:
        // retType PropName { set; }
        byte Points { get; }

        // Implicitly public and abstract.
        byte GetNumberOfPoints();
    }
}
