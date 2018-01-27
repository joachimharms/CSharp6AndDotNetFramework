using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_001_BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;

        private int currSpeed;

        public Car(int max)
        {
            this.maxSpeed = max;
        }

        public Car()
        {
            this.maxSpeed = 55;
        }

        public int Speed
        {
            get
            {
                return this.currSpeed;
            }

            set
            {
                this.currSpeed = value;
                if (this.currSpeed > this.maxSpeed)
                {
                    this.currSpeed = this.maxSpeed;
                }
            }
        }
    }


}
