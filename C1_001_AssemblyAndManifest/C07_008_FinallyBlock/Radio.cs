using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_008_FinallyBlock
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
            {
                Console.WriteLine("Jamming...");
            }
            else
            {
                Console.WriteLine("Quiet time...");
            }
        }

    }
}
