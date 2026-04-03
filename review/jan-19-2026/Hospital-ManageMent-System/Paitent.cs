using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3.Hospital_ManageMent_System
{
    internal abstract class Paitent
    {
        protected string name;
        protected string illness;
        protected int id;

        public Paitent(string name, string illness, int id)
        {
            this.name = name;
            this.illness = illness;
            this.id = id;
        }

        public abstract double CalculateBill();

        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nIllness: {illness}";
        }
    }
}

