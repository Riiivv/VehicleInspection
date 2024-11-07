using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleInspection.Models;

namespace VehicleInspection.Models
{
    public class Car : VehicleWithWheels
    {
        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }
        public override bool InspectionStatus()
        {
            return (DateTime.Now.Year - ProductionDate.Year > 4) && (DateTime.Now.Year - LastInspection.Year > 2);
        }

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }
        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 16 : 22;
            Console.WriteLine(isWinterTire
                ? "Car tire type set to winter tires with max rim size 16."
                : "Car tire type set to summer tires with max rim size 22.");
        }
    }
}
