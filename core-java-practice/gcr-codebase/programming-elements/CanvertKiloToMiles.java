import java.util.*;

public class CanvertKiloToMiles {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //take input from user
        double kilo = sc.nextDouble();
        double miles = kilo * 0.621371;//convert kilo to miles
        System.out.print(miles);
    }
}
