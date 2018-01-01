﻿using System;

namespace C05_001_SimpleClassExample
{
    public class Motorcycle
    {
        //public void PopAWheely()
        //{
        //    Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        //}

        public int driverIntensity;
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }
        // Put back the default constructor, which will
        // set all data members to default vaules.
        public Motorcycle() { }
        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

        // New members to represent the name of the driver.
        public string name;
        public void SetDriverName(string name)
        {
            // name = name;

            // Verwendung von this löst die obige Mehrdeutigkeit von Parameter und Datenfeld auf:
            this.name = name;

        }
    }
}