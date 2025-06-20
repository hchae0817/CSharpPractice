
//1.요구사항 정리(간단하게):
//차량이 입장하고 출차 가능

//차량 종류: 자동차, 오토바이, 대형차 등
//주차 공간 타입: 소형, 중형, 대형
//주차 공간 할당 및 해제

//요금 계산 (기본/시간당)
//주차장 용량 제한
//주차 공간 상태 확인

using ParkingLot;
using ParkingLot.Interfaces;
using ParkingLot.Models;
using ParkingLot.Services;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //var car1 = new Car("Honda", "Red", ParkingType.Small);
            //var carfare = car1.CalculatePrice();
            //Console.WriteLine($"Total price: {carfare}");

            var spots = new List<ParkingSpot>()
            {
                new ParkingSpot { SpotType = ParkingType.Small },
                new ParkingSpot { SpotType = ParkingType.Medium },
                new ParkingSpot { SpotType = ParkingType.Large }
            };

            var manager = new ParkingLotManager(spots);

            var car = new Vehical("Honda", "Red", ParkingType.Small);

            var ticket = manager.ParkVehical(car);
            if (ticket != null)
            {
                System.Threading.Thread.Sleep(5000); // 5s parking

                var fare = manager.ExitVehical(ticket.TicketId);
                Console.WriteLine($"Vehical Info: {car.Name}, {car.VehicalParkingType}");

            }


        }
    }
}


