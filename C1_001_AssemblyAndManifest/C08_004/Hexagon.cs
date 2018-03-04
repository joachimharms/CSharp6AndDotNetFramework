using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_004
{
    // Hexagon now implements IPointy.
    // Hexagon supports IPointy and IDraw3D.
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }

        public Hexagon(string name) : base(name) { }

        // IPointy implementation.
        public byte Points
        {
            get
            {
                return 6;
            }
        } 

        public override void Draw()
        {
            Console.WriteLine($"Drawing {base.PetName} the Hexagon");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!"); 
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
