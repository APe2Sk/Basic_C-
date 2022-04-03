using System;
using System.Collections.Generic;

namespace class08Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAgain = "yes";
            Queue<int> numbers = new Queue<int>();
            do
            {
                Console.WriteLine("Please enter a number for the number list: ");
                bool isSuccess = int.TryParse(Console.ReadLine(), out int result);
                if(isSuccess)
                {
                    numbers.Enqueue(result);
                    Console.WriteLine("Do you want to input any number again? (yes/no)");
                    inputAgain = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("You did not entered any number");
                }

            }
            while (inputAgain == "yes");

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
