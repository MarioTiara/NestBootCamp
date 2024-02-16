

namespace BasicCSharp
{
    public abstract class Car
    {
        public abstract void GetEngineType();
        public void GetWheels()
        {
            Console.WriteLine("Wheels: 4");
        }
    }
    public class ElectricCar : Car
    {
        public override void GetEngineType()
        {
            Console.WriteLine("Engine Type: Electric motor");
        }
    }
    public class GasolineCar : Car
    {
        public override void GetEngineType()
        {
            Console.WriteLine("Engine type:  Combustion Engine");
        }
    }
}