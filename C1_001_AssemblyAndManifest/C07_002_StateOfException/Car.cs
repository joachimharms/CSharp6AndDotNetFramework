using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_002_StateOfException
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

                    //// Use the "throw" keyword to raise an exception.
                    //throw new Exception(string.Format($"{this.PetName} has overheated!"));



                    // We need to call the HelpLink property, thus we need to
                    // create a local variable before throwing the Exception object.
                    Exception ex =
                    new Exception(string.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";


                    // Stuff in custom data regarding the error.
                    ex.Data.Add("TimeStamp",
                    string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot.");

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
