import java.util.*;

public class CircleArea {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in); // creating scanner object
        double rad = sc.nextDouble(); // taking radius input
        double area = Math.PI * rad * rad; // calculating 
        System.out.println(area); // printing the area
    }
}
