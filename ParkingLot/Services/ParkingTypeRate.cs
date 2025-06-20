using ParkingLot.Interfaces;
namespace ParkingLot.Services
{
    public class ParkingTypeRate
    {
        public float Calculate(ParkingType parkingType)
        {
            switch (parkingType)
            {
                case ParkingType.Small: return 1.5f;
                case ParkingType.Medium:  return 3.5f;
                case ParkingType.Large: return 5.5f;

            }
            return 0f;
        }
    }
}
