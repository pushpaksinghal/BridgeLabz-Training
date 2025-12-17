import java.util.Scanner;

public class ParameterOfRectangle {
    public static void main(String[]args){
        Scanner sc = new Scanner(System.in);
        //take input from user
        double l = sc.nextDouble();
        double b = sc.nextDouble();
        double para = 2 * (l + b);//cal perimeter of rectangle
        System.out.print(para);

    }
}
