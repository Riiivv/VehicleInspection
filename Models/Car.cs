using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection.Models
{
    public class Car : Vehicle 
    {
        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection) : base(brand,model,productionDate,lastInspection) 
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
    }
}
