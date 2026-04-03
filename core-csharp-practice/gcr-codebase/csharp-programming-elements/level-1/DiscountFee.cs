using System;

class DiscountFee{
    static void Main(String []args){
        // finding the discount off of teh original fee sa that it can be subtrscted and find  the discounted fee

        int amount = 125000;
        int discount = 10;
        //calculation
        int discountPrice = (amount/100)*discount;
        int finalFee = amount-discountPrice;

        Console.WriteLine("The discount amount is INR"+discountPrice+"and the discounted Fees is "+finalFee);
    }
}