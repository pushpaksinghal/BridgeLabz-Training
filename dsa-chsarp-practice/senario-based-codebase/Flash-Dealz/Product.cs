using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Flash_Dealz
{
    internal class Product
    {
        // making a incapsulated class
        private int productId;
        private string name;
        private double discount;
        private double price;
        private double discountPrice;
        // amking a constructure
        public Product(int productId, string name, double discount, double price)
        {
            this.productId = productId;
            this.name = name;
            this.discount = discount;
            this.price = price;
            discountPrice = price - (price * discount / 100);
        }
        // making getter for private fields
        public int GetId() { return productId; }
        public string GetName() { return name; }
        public double GetDiscount() { return discount; }
        public double GetPrice() { return price; }
        public double GetDiscountPrice() {return discountPrice; }

        public override string ToString()
        {
            return "ID: " + productId+"\nName: "+name+"\nDiscount: "+discount+"\nActual Price: "+price+"\nDiscounted Price: "+discountPrice;
        }
    }
}
