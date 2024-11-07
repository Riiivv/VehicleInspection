using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleInspection.Models;

namespace VehicleInspection.Models
{
    public class Truck : Vehicle
    {
        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection) : base(brand, model, productionDate, lastInspection)
        {
        }
        public override bool InspectionStatus()
        {
            return (DateTime.Now.Year - ProductionDate.Year > 1) && (DateTime.Now.Year - LastInspection.Year > 1);
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }
        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
            Console.WriteLine(isWinterTire
                ? "Truck tire type set to winter tires with max rim size 17."
                : "Truck tire type set to summer tires with max rim size 20.");
        }
    }
}