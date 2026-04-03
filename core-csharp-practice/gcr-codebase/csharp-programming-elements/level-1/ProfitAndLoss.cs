using System;

class ProfitAndLoss{
    static void Main(String[] args){
        // finding out the profit off of teh sell made
        int costPrice =129;
        int sellingPrice = 191;
        int profit = sellingPrice-costPrice;
        float profitPercentage = (profit*100f)/costPrice;

        Console.WriteLine("The cost price isINR"+costPrice+" and the Selling Price is INR"+sellingPrice+" \n The Profit is INR"+profit+"and teh Profit Percentage isINR"+profitPercentage);
    }
}