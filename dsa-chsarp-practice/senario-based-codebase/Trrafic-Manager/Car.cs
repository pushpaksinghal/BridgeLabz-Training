using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Trrafic_Manager
{
    internal  class Car
    {
        private int carId;
        private int exitQueueId;

        public Car(int carId, int exitQueueId)
        {
            this.carId = carId;
            this.exitQueueId = exitQueueId;
        }

        public int CarId() {  return carId; }
        public int ExitQueueId() { return exitQueueId; }
    }
}
