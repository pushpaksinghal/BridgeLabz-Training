import java.util.*;

public class VolumeOfCylinder {
    public static void main(String[] args){
        Scanner sc =new Scanner(System.in); // creating scanner object
        double rad = sc.nextDouble(); // taking radius input
        double h = sc.nextDouble(); // taking height input
        double vol = Math.PI * rad * rad * h; // calculating volume
        System.out.println(vol); // printing the volume
    }
}
