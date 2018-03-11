// CONFIRMED from <EkaterinKostadinov>
using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var forthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNum:d4} {secondNumber:d4} {thirdNumber:d4} {forthNumber:d4}");
        }
    }
}
