using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_010_MemberShadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            // This calls the Draw() method of the ThreeDCircle.
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            // This calls the Draw() method of the parent!
            ((Circle)o).Draw();
            Console.ReadLine();
        }
    }
}
