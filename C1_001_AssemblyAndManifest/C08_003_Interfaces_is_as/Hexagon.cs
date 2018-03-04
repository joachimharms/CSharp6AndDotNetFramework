using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_003_Interfaces_is_as
{
    // Hexagon now implements IPointy.
    class Hexagon : Shape, IPointy
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

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
