﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_010_MemberShadowing
{
    class Hexagon : Shape
    {
        public Hexagon() { }

        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {base.PetName} the Hexagon");
        }
    }
}
