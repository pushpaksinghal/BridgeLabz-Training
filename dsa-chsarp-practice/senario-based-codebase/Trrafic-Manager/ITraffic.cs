using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Trrafic_Manager
{
    internal interface ITraffic
    {
        void AddCarToRoad(int roadId, int carId, int exitId);
        void MoveCarToRoundabout(int roadId);
        void ExitRoundabout();

        void RoundaboutStatus();
    }
}
