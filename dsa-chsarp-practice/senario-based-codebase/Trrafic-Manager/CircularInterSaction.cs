using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Trrafic_Manager
{
    class CarNode<Car>
    {
        public Car car;
        public CarNode<Car> next;

        public CarNode(Car car)
        {
            this.car = car;
            next = null;
        }
    }
    internal class CircularInterSaction<Car>
    {
        private CarNode<Car> head;

        public CircularInterSaction()
        {
            head = null;
        }
        public CarNode<Car> GetHead() { return head; }
        public void InsertAtEnd(Car car)
        {
            CarNode<Car> newNode = new CarNode<Car>(car);

            if (head == null)
            {
                head = newNode;
                newNode.next = head; 
            }
            else
            {
                CarNode<Car> temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                newNode.next = head;
            }
        }

        public void DeleteFromBeginning()
        {
            if (head == null)
            {
                return;
            }
            if (head.next == head) 
            {
                head = null;
                return;
            }
            CarNode<Car> temp = head;
            CarNode<Car> lastNode = head;
            while (lastNode.next != head)
            {
                lastNode = lastNode.next;
            }
            head = head.next;
            lastNode.next = head;
        }

        public int DisplayCount()
        {
            int countt= 0;
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return 0;
            }

            CarNode<Car> temp = head;
            do
            {
                countt++;
                temp = temp.next;
            } while (temp != head);

            return countt;
        }
    }
}
