using System;

class YoungAndTall {
    static void Main(String[] args) {
        //taking input
        int amarAge = Convert.ToInt32(Console.ReadLine());
        int akbarAge= Convert.ToInt32(Console.ReadLine());
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        double amarHight =  Convert.ToDouble( Console.ReadLine());
        double akbarHight = Convert.ToDouble(Console.ReadLine());
        double anthonyHight = Convert.ToDouble(Console.ReadLine());

        //finding out the youngest and tallest
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));


        double tallestHight = Math.Max(amarHight, Math.Max(akbarHight, anthonyHight));

        Console.WriteLine("youngest age is " + youngestAge);
        Console.WriteLine("Tellest height is " + tallestHight);
    }
}
