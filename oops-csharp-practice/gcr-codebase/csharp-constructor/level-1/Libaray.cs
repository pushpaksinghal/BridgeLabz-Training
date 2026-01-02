using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.level_1
{
    internal class Libaray
    {
        //created the atributes
        string title;
        string author;
        double price;
        bool avaliable;
        //default con
        public Libaray()
        {
            this.title = "the heat of Lava";
            this.author = "Mount ain";
            this.price = 0.0;
            this.avaliable = false;
        }
        //parameter con
        public Libaray(string title, string author, double price, bool avaliable)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.avaliable = avaliable;
        }
        // method to find if it is avalible
        public void IsItAvaliable()
        {
            if (avaliable)
            {
                this.avaliable = false;
                Console.WriteLine("it is avalable");
            }
            else
            {
                Console.WriteLine("it is not avalible");
            }
        }

    }

    class Display()
    {
        static void Main(String[] args)
        {
            // callin ghte clas in main
            Libaray b1 = new Libaray();
            Libaray b2 = new Libaray("harry potter ", "jk rowling", 12.32, true);

            b1.IsItAvaliable();
            b2.IsItAvaliable();
            b2.IsItAvaliable();
        }
    }
}
