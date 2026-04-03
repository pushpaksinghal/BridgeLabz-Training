using System;

class SwitchCaseCalculator {
    static void Main(String[] args) {

        // taking the input from the user of teh two number and the operator
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        string op = Console.ReadLine();
        //using switch case to toggle between the operators
        switch (op) {
            case "+":
                Console.WriteLine(first+ second);
                break;

            case "-":
                Console.WriteLine(first- second);
                break;

            case "*":
                Console.WriteLine(first* second);
                break;

            case "/":
                Console.WriteLine(first/ second);
                break;

            default:
                Console.WriteLine("Invalid opareter");
                break;
        }
    }
}
