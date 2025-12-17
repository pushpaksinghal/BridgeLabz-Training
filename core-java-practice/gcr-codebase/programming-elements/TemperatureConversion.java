
import java.util.*;   //importing scanner
public class TemperatureConversion {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);//added scanner obj
        double cel = sc.nextDouble();//taking input
        double fah = (cel * 9/5) + 32;//conversion
        System.out.println(fah);//printing the converted output
    }
}
