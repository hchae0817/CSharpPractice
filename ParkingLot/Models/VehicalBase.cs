using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot.Interfaces;

namespace ParkingLot.Models
{
    public abstract class VehicleBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ParkingType ParkingType { get; set; }
        public DateTime StartTime { get; set; }

        public VehicleBase(string name, string description, ParkingType parkingType)
        {
            Name = name;
            Description = description;
            ParkingType = parkingType;
            StartTime = DateTime.UtcNow;
        }

        // Common behavior: duration-based pricing
        public virtual float CalculateDurationHours()
        {
            return (float)(DateTime.UtcNow - StartTime).TotalHours;
        }

        // Abstract method forces subclass to implement pricing logic
        public abstract float CalculatePrice();
    }
}
