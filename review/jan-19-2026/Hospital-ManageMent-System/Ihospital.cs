using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3.Hospital_ManageMent_System
{
    internal interface Ihospital
    {
        void AddPaitet();

        void InRemovePaitent(int index);
        void OutRemovePaitent(int index);

        void InBillGenerate(int index);
        void OutBillGenerate(int index);

        void InSort();
        void OutSort();

        void InDisplay();
        void OutDisplay();
    }
}

