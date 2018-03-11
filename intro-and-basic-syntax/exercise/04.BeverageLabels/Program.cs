//CONFIRMED from myilkova
// 100/100 in judge
using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive from the console the product name as a string
            var productName = Console.ReadLine();
            /* In the next three lines we receve the volume, 
             * energy and sugar content per 100 ml
             * as an integer */
            var productVolume = int.Parse(Console.ReadLine());
            var energyContentPer100ml = int.Parse(Console.ReadLine());
            var sugarContentPer100ml = int.Parse(Console.ReadLine());

            // We calculate the energy and sugar content for the given volume
            var energyContentForGivenVolume = productVolume * energyContentPer100ml / 100.0;
            var sugarContentForGivenVolume = productVolume * sugarContentPer100ml / 100.0;
            
            // We print them on the console
            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{energyContentForGivenVolume}kcal, {sugarContentForGivenVolume}g sugars");
        }
    }
}
