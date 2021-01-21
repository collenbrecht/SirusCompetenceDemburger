using Domain;
using System;

namespace Demburger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Demburger World!");
            AskOrder();
        }

        private static void AskOrder()
        {
            Registry registry = new Registry();
            var running = true;
            while (running)
            {
                Console.WriteLine("How many burgers do you want?");
                Console.WriteLine("Please enter a positive integer and press enter.");
                Console.WriteLine("Just press enter to quit.");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    running = false;
                    continue;
                }
                if (int.TryParse(input, out int numberOfBurgers) && numberOfBurgers > 0)
                {
                    Console.WriteLine($"The order of {numberOfBurgers} burgers costs {registry.GetOrderPrice(numberOfBurgers)}");
                }
                else
                {
                    Console.WriteLine("Input not correct.");
                }
            }
        }
    }
}
