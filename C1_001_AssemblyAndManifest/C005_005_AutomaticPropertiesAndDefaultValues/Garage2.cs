namespace C005_005_AutomaticPropertiesAndDefaultValues
{
    public class Garage2
    {
       
        
         // The hidden int backing field is set to zero!
         public int NumberOfCars { get; set; }

         // The hidden Car backing field is set to null!
         public Car MyCar { get; set; }

        public Garage2()
        {
            MyCar = new Car();
            NumberOfCars = 1;
        }

        public Garage2(Car c, int numOfCars)
        {
            this.MyCar = c;
            this.NumberOfCars = numOfCars;
        }
        
    }
}