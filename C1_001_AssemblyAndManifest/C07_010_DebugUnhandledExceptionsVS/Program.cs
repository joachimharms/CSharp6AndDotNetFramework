using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_010_DebugUnhandledExceptionsVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Rusty", 90);
            // Trigger eine Exception, ohne Try- Catch Blöcke um das Debuging von unbehandelten Ausnahmen mit VS zu üben:
            myCar.Accelerate(2000);
        }
    }
}
