using VehicleInspection.Models;

namespace VehicleInspection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car object
            VehicleWithWheels myCar = new Car("Audi", "A6", new DateTime(2015, 5, 25), new DateTime(2019, 10, 23));
            myCar.SetTireType(true); // Set to winter tires
            Console.WriteLine(myCar.DisplayInfo());
            Console.WriteLine(myCar.GetInterfaceInfo()); // Call to GetInterfaceInfo

            Console.WriteLine();

            // Truck object
            VehicleWithWheels myTruck = new Truck("Volvo", "FH16", new DateTime(2019, 4, 15), new DateTime(2020, 6, 10));
            myTruck.SetTireType(false); // Set to summer tires
            Console.WriteLine(myTruck.DisplayInfo());
            Console.WriteLine(myTruck.GetInterfaceInfo()); // Call to GetInterfaceInfo



        }
    }
}
