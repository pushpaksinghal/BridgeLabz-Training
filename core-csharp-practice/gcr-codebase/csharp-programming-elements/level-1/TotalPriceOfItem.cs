using System;

class TotalPriceOfItem{
    static void Main(String[] args){
        //given the unit prince and the quantity 
        ///finding  the total price
        //taking input from user 
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        int quantity = Convert.ToInt32(Console.ReadLine());

        double total = unitPrice*quantity;

        Console.WriteLine("The total purchase price is INR "+total+"if the quantity is "+quantity+"and the unit price is "+unitPrice);
    }
}