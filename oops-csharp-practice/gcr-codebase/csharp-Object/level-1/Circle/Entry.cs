using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_objects.Circle
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            CircleClass obj = new CircleClass(12.4);
            double area = obj.Area(12.4);
            obj.Display(area,12.4);
        }
    }
}
