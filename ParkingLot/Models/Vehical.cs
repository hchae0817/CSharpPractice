using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot;
using ParkingLot.Interfaces;

namespace ParkingLot.Models
{
    public class Vehical
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ParkingType VehicalParkingType { get; set; }
        public DateTime StartTime { get; set; }

        public Vehical(string name, string description, ParkingType type)
        {
            Name = name;
            Description = description;
            VehicalParkingType = type;
        }
    }

}
