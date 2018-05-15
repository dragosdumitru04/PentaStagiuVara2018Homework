using System;

namespace PentaStagiuWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int target = rng.Next(0, 100);

            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != target)
            {
                if (number < target)
                {
                    Console.WriteLine("The number was too small");
                }
                else if (number > target)
                {
                    Console.WriteLine("The number was too big");
                }

                Console.Write("Input a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Congratulations! You guessed the number!");
        }
    }
}