//CONFIRMED from myilkova
// after Issue#1 was resolved
using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
		// we are reading some variables
            var nameOfPerson = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());
		// concatenating strings
            var health = new string('|', currentHealth) + new string('.', maximumHealth - currentHealth);
            var energy = new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy);
		//printing result
            Console.WriteLine("Name: {0}", nameOfPerson);
            Console.WriteLine("Health: |" + health + "|");
            Console.WriteLine("Energy: |" + energy + "|");
        }
    }
}
