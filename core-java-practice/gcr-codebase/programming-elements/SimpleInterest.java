import java.util.Scanner;

public class SimpleInterest {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //take input from user
        double pri = sc.nextDouble();
        double rate = sc.nextDouble();
        double time = sc.nextDouble();
        double si = (pri * rate * time) / 100;//cal simple interset
        System.out.print(si);

    }
}
