using System;

class UserDiscountFee{
    static void Main(String []args){
        //this is the same as before one 
        ////taking input from user
        int amount = Convert.ToInt32(Console.ReadLine());
        int discount =Convert.ToInt32(Console.ReadLine()) ;
        int discountPrice = (amount/100)*discount;
        int finalFee = amount-discountPrice;

        Console.WriteLine("The discount amount is INR"+discountPrice+"and the discounted Fees is "+finalFee);
    }
}