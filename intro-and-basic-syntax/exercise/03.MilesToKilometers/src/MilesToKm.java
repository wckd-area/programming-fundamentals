//CONFIRMED from aquaruiz
import java.util.Scanner;

/**
 * Created by Mira on 1/23/2018.
 */
public class MilesToKm {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double miles = Double.parseDouble(scanner.nextLine());
        double kmPerMile = 1.60934;
        double km = miles * kmPerMile;
        System.out.printf("%.2f", km);
    }
}
