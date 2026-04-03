using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Review_3.Hospital_ManageMent_System
{
    internal class OutPaitent : Paitent
    {
        private int hours;
        private int roomId;

        public OutPaitent(string name, string illness, int id, int hours, int roomId)
            : base(name, illness, id)
        {
            this.hours = hours;
            this.roomId = roomId;
        }

        public override double CalculateBill()
        {
            return hours * 100;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nRoom Id: {roomId}\nHours Visited: {hours}\nBill: {CalculateBill()}";
        }
    }
}

