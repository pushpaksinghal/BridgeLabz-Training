using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgelabzTraining.senario_based.Flash_Dealz
{
    internal class ProductUtility:IProduct
    {
        //uisng the linked list to make the add and bestdeal method and hiding the implementation by using interface
        ProductLinkedList productLinkedList = new ProductLinkedList();
        int count = 0;
        public void AddProduct()
        {
            int id = count++;
            string name = Console.ReadLine();
            double discount = Convert.ToDouble(Console.ReadLine()); 
            double price = Convert.ToDouble(Console.ReadLine());

            productLinkedList.Add(new Product(id, name, discount, price));

            Console.WriteLine("The Product has been added");
        }

        public void GetBestDeal()
        {
            ProductNode head = productLinkedList.GetHead();
            head = productLinkedList.QuickSort(head);

            Console.WriteLine("The most discount is on " + head.product.GetName() + " of " + head.product.GetDiscount() + " and the discounted price is " + head.product.GetDiscountPrice());
        }
    }
}
