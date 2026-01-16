using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Trrafic_Manager
{
    internal class TrafficUtility:ITraffic
    {
        QueueRoad roadOne = new QueueRoad(10,01);
        QueueRoad roadTwo = new QueueRoad(10,02);
        QueueRoad roadThree = new QueueRoad(10,03);
        QueueRoad roadFour = new QueueRoad(10,04);

        CircularInterSaction<Car> roundAbout = new CircularInterSaction<Car>();

        public void AddCarToRoad(int roadId, int carId, int exitId)
        {
            Car car = new Car(carId, exitId);

            QueueRoad road = GetRoadById(roadId);
            if (road == null)
            {
                Console.WriteLine("Invalid road id");
                return;
            }

            road.Enqueue(car);
        }

        private QueueRoad GetRoadById(int id)
        {
            if (id == 1) return roadOne;
            if (id == 2) return roadTwo;
            if (id == 3) return roadThree;
            if (id == 4) return roadFour;
            return null;
        }

        public void MoveCarToRoundabout(int roadId)
        {
            QueueRoad road = GetRoadById(roadId);
            if (road == null) return;

            Car car = road.Dequeue();
            if (car != null)
            {
                roundAbout.InsertAtEnd(car);
                Console.WriteLine($"Car {car.CarId()} entered roundabout");
            }
        }

        public void ExitRoundabout()
        {
            roundAbout.DeleteFromBeginning();
            Console.WriteLine("One car exited the roundabout");
        }

        public void RoundaboutStatus()
        {
            int count = roundAbout.DisplayCount();
            Console.WriteLine($"Cars in roundabout: {count}");
        }

    }
}
