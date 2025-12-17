import java.util.*;

public class PowerCalculation {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //take input from user
        double base = sc.nextDouble();
        double ex = sc.nextDouble();
       double r =  Math.pow(base,ex);//cal power
        System.out.print(r);
    }
}
