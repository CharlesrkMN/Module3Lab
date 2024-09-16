using System;
namespace TacoBurritoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Taco & Burrito Decision Maker!");
            Console.Write("How hungry are you (1-10)? ");
            int hungerLevel = int.Parse(Console.ReadLine());

            if (hungerLevel >= 8)
            {
                Console.WriteLine("You're super hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            }
            else
            {
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            }
            
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend: {recommendation}");

            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a taco and burrito champion!");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Taco time!");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack.");
                    break;
            }
        }
    }
}

