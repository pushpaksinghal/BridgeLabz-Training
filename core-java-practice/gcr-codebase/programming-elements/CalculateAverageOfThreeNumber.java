import java.util.*;

public class CalculateAverageOfThreeNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //take input from user
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        double ave = (a+b+c) / 3;//cal average
        System.out.print(ave);
    }
}
