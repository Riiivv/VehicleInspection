using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
    }
}