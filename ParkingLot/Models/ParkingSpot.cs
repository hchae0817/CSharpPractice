using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot.Interfaces;

namespace ParkingLot.Models
{
    public class ParkingSpot
    {
        public string SpotId { get; set; } = Guid.NewGuid().ToString(); 
        public ParkingType SpotType { get; set; } 

        public bool IsOccupied { get; set; } = false;
        public Vehical? ParkedVehical { get; set; }

        public bool CanFitVehical(Vehical vehical)
        {
            // e.g: cant fit medium on small spot.
            return vehical.VehicalParkingType <= SpotType;
        }

        public void AssignVehical(Vehical vehical)
        {
            if (IsOccupied || !CanFitVehical(vehical))
                throw new InvalidOperationException("Spot not available");
            ParkedVehical = vehical;
            IsOccupied = true;
        }

        public void RemoveVehical()
        {
            ParkedVehical = null;
            IsOccupied = false;
        }
    }
}
