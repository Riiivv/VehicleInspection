using VehicleInspection.Models;

namespace VehicleInspection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carBrand = "Audi";
            string carModel = "A6";
            DateTime CarProductionTime = new DateTime(2018, 2, 25);
            DateTime lastCarInspection = new DateTime(2020, 5, 15);
            Car car = new Car(carBrand,carModel,CarProductionTime,lastCarInspection);

            string truckBrand = "Volvo";
            string truckModel = "FH16";
            DateTime truckProductionDate = new DateTime(2022, 1, 15);
            DateTime lastTruckInspection = new DateTime(2023, 2, 20);
            Truck truck = new Truck(truckBrand, truckModel, truckProductionDate, lastTruckInspection);

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine("Inspection Needed: " + (car.InspectionStatus() ? "Yes" : "No"));


            Console.WriteLine(truck.DisplayInfo());
            Console.WriteLine("Inspection needed: " + (truck.InspectionStatus() ? "Yes" : "No"));
        }
    }
}
