using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot;
using ParkingLot.Interfaces;
using ParkingLot.Services;

namespace ParkingLot.Models
{
    public class Car : VehicleBase
    {
        public Car(string name, string desc, ParkingType type)
            : base(name, desc, type) { }

        public override float CalculatePrice()
        {
            float rate = new ParkingTypeRate().Calculate(ParkingType);
            float hours = CalculateDurationHours();
            return rate * hours;
        }
    }
}
