using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public class ParkingTicket
    {
        public string TicketId { get; set; } = Guid.NewGuid().ToString();
        public Vehical Vehical { get; set; }
        public ParkingSpot Spot { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }

        public ParkingTicket(Vehical vehical, ParkingSpot spot)
        {
            Vehical = vehical;
            Spot = spot;
            EntryTime = DateTime.UtcNow;
        }

        public float CalculateFare()
        {
            var endTime = ExitTime ?? DateTime.UtcNow;
            var durationHours = (float)(endTime - EntryTime).TotalHours;

            var rate = new ParkingLot.Services.ParkingTypeRate().Calculate(Spot.SpotType);
            return rate * durationHours;
        }

        public void MarkExit()
        {
            ExitTime = DateTime.UtcNow;
        }
    }
}

