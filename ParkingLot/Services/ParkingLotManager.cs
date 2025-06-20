using System;
using System.Collections.Generic;
using System.Linq;
using ParkingLot.Models;

namespace ParkingLot.Services
{
    public class ParkingLotManager
    {
        private readonly List<ParkingSpot> _spots;
        private readonly Dictionary<string, ParkingTicket> _activeTickets;

        public ParkingLotManager(List<ParkingSpot> spots)
        {
            _spots = spots;
            _activeTickets = new Dictionary<string, ParkingTicket>();
        }

        // incoming cars
        public ParkingTicket? ParkVehical(Vehical vehical)
        {
            // find spot for avaiable size 
            var spot = _spots.FirstOrDefault(s => !s.IsOccupied && s.CanFitVehical(vehical));
            if (spot == null)
            {
                Console.WriteLine("No available spot for this vehicle.");
                return null;
            }

            spot.AssignVehical(vehical);

            var ticket = new ParkingTicket(vehical, spot);
            _activeTickets[ticket.TicketId] = ticket;

            Console.WriteLine($"Vehicle parked. Ticket ID: {ticket.TicketId}");
            return ticket;
        }

        // outcoming cars
        public float? ExitVehical(string ticketId)
        {
            if (!_activeTickets.ContainsKey(ticketId))
            {
                Console.WriteLine("Invalid ticket ID.");
                return null;
            }

            var ticket = _activeTickets[ticketId];
            ticket.MarkExit();

            var fare = ticket.CalculateFare();
            ticket.Spot.RemoveVehical();
            _activeTickets.Remove(ticketId);

            Console.WriteLine($"Vehicle exited. Fare: {fare}");
            return fare;
        }
    }
}
