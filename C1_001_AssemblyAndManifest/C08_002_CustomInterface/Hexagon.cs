using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_002_CustomInterface
{
    class Hexagon : Shape
    {
        public Hexagon() { }

        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing the {base.PetName} Hexagon");
        }
    }
}
