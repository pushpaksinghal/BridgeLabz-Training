using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.WareHouseStorage
{
    internal class Storage<T> where T:WareHousrItem
    {
        List<WareHousrItem> items = new List<WareHousrItem>();

        public void Add()
        {
            Console.WriteLine("1.furniture\n2.groceries\n3.elecronics");
            int choice = Convert.ToInt32(Console.ReadLine());
            int id = Convert.ToInt32(Console.ReadLine());
            string conpanyname = Console.ReadLine();
            if (choice == 1)
            {
                int piece = Convert.ToInt32(Console.ReadLine());
                items.Add(new Furniture<int>(id, conpanyname, piece));
            }
            else if(choice == 2)
            {
                bool fresh = Convert.ToBoolean(Console.ReadLine());
                items.Add(new Groceries<bool>(id, conpanyname, fresh));
            }
            else
            {
                double model = Convert.ToDouble(Console.ReadLine());
                items.Add(new Electornics<double>(id, conpanyname, model));
            }
            Console.WriteLine("Item added.");
        }

        public void Display()
        {
            foreach(WareHousrItem item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
