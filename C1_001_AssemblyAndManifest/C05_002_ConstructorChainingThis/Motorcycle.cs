namespace C05_002_ConstructorChainingThis
{
    public class Motorcycle
    {
        class Motorcycle
        {
            public int driverIntensity;
            public string driverName;
            public Motorcycle() { }

            // Redundent constructor logic!
            public Motorcycle(int intensity)
            {
                if (intensity > 10)
                {
                    intensity = 10;
                }
                driverIntensity = intensity;
            }
            public Motorcycle(int intensity, string name)
            {
                if (intensity > 10)
                {
                    intensity = 10;
                }
                driverIntensity = intensity;
                driverName = name;
            }
        }
}