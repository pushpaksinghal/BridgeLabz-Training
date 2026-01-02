using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_objects.BookDetail
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            BookDetail obj = new BookDetail("Harry potter and the cursed child", "J.K.Rowling", 12.99);
            obj.Display();
        }
    }
}
