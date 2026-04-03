using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Trrafic_Manager
{
    internal class QueueRoad
    {
        private Car[] cars;
        public int id;
        private int front;
        private int rear;
        private int count;
        private int capasity;

        public QueueRoad(int size, int id)
        {
            this.capasity = size;
            this.cars = new Car[size];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
            this.id = id;
        }

        public void Enqueue(Car car)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot insert.");
                return;
            }
            // Use modulo arithmetic to wrap the rear pointer
            rear = (rear + 1) % capasity;
            cars[rear] = car;
            count++;
            Console.WriteLine("car entered");
        }

        public bool IsFull()
        {
            return count == capasity;
        }

        public Car Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return null; 
            }
            Car car= cars[front];
            front = (front + 1) % capasity;
            count--;
            return car;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public Car Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. No front element.");
                return null; // Or throw an exception
            }
            return cars[front];
        }


    }
}
