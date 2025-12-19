using System;

class DiscountFee{
    static void Main(String []args){
        int amount = 125000;
        int discount = 10;
        int discountPrice = (amount/100)*discount;
        int finalFee = amount-discountPrice;

        Console.WriteLine("The discount amount is INR"+discountPrice+"and the discounted Fees is "+finalFee);
    }
}