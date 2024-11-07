using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleInspection.Models;

namespace VehicleInspection.Models
{
    public interface IWheels
    {
        int MaxRimSize { get; set; }

        void SetTireType(bool IsWinterTire)
        {

        }
        public string Info()
        {
            return "Brug mig for alle objekter som køres på hjul.";
        }
    }
}
