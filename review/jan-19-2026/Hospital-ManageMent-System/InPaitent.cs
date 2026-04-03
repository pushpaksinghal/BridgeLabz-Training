using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Review_3.Hospital_ManageMent_System
{
    internal class InPaitent : Paitent
    {
        private int days;
        private int roomId;

        public InPaitent(string name, string illness, int id, int days, int roomId)
            : base(name, illness, id)
        {
            this.days = days;
            this.roomId = roomId;
        }

        public override double CalculateBill()
        {
            return days * 500;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nRoom Id: {roomId}\nDays Stayed: {days}\nBill: {CalculateBill()}";
        }
    }
}

