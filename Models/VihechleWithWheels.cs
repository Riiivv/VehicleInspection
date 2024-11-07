using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection.Models
{
    public abstract class VehicleWithWheels : Vehicle, IWheels
    {
        public int MaxRimSize { get; set; }

        protected VehicleWithWheels(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {

        }

        public abstract void SetTireType(bool isWinterTire);

        public string GetInterfaceInfo()
        {
            return ((IWheels)this).Info();
        }
    }
}