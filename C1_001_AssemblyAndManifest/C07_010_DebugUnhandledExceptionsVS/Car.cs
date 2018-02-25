using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_010_DebugUnhandledExceptionsVS
{
    class Car
    {
        // Konstante für Höchstgeschwindigkeit.
        public const int MaxSpeed = 100;

        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // Is the car still operational?
        private bool carlIsDead;

        // A car has a radio.
        private Radio theMusicBox = new Radio();

        // Constructors
        public Car() { }
        public Car(string name, int speed)
        {
            this.CurrentSpeed = speed;
            this.PetName = name;
        }

        // Delegate request to inner object.
        public void CrankTunes(bool state)
        {
            this.theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.
        public void Accelerate(int delta)
        {
            // added new ArgumentOutOfRangeException for learning to handle multiple exceptions
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero.");
            }


            if (carlIsDead)
            {
                Console.WriteLine($"{this.PetName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    //Console.WriteLine($"{this.PetName} has overheated!");
                    CurrentSpeed = 0;
                    carlIsDead = true;

                    // Verwendung einer Custom Exception:
                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else
                {
                    Console.WriteLine($"=> Current Speed = {CurrentSpeed}");
                }
            }
        }

    }
}
