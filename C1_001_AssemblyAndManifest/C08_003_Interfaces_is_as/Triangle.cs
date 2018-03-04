using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_003_Interfaces_is_as
{
    // New Shape derived class named Triangle.
    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Triangle.");
        }

        // IPointy implementation.
        public byte Points
        {
            get
            {
                return 3;
            }
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
