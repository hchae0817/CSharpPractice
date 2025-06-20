using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot.Models;

// old interface now using abstract class for better scalbility.
namespace ParkingLot.Interfaces
{
    public interface IVehical
    {
        public float CalculatePrice(Vehical vehical); 

    }
}
