using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_001_SimpleException
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

                    // Use the "throw" keyword to raise an exception.
                    throw new Exception(string.Format($"{this.PetName} has overheated!"));
                }
                else
                {
                    Console.WriteLine($"=> Current Speed = {CurrentSpeed}");
                }
            }
        }

    }
}
