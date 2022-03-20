using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_Class02
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Exercise 7 from class

            Console.WriteLine("Please enter a number from 1 to 3.");
            bool number = int.TryParse(Console.ReadLine(), out int res);
            Console.WriteLine(number);
            Console.WriteLine(res);
            // int res = 1;

            switch (res)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("You did not entered the number between 1 and 3");
                    break;
            }

            #endregion


            #region HW 1
            Console.WriteLine("==========================");
            Console.WriteLine("Please eneter two numbers.");

            bool num1 = int.TryParse(Console.ReadLine(), out int num1Res);
            bool num2 = int.TryParse(Console.ReadLine(), out int num2Res);

            Console.WriteLine("Please operation that you would want to be done ( +, - , * , / ).");
            string operationInput = Console.ReadLine();

            switch(operationInput)
            {
                case "+":
                    Console.WriteLine(num1Res + num2Res);
                    break;
                case "-":
                    Console.WriteLine(num1Res - num2Res);
                    break;
                case "*":
                    Console.WriteLine(num1Res * num2Res);
                    break;
                case "/":
                    Console.WriteLine(num1Res / num2Res);
                    break;
                default:
                    Console.WriteLine("You did not entered the correct operator. Please try again!");
                    break;
            }

            #endregion

            #region HW ex2

            Console.WriteLine("==========================");
            Console.WriteLine("Please eneter four numbers in order to calculate their average.");

            bool num3 = int.TryParse(Console.ReadLine(), out int num3Res);
            bool num4 = int.TryParse(Console.ReadLine(), out int num4Res);
            bool num5 = int.TryParse(Console.ReadLine(), out int num5Res);
            bool num6 = int.TryParse(Console.ReadLine(), out int num6Res);

            int averageRes = (num3Res + num4Res + num5Res + num6Res) / 4;
            Console.WriteLine("The average result is "+averageRes);

            #endregion

            #region HW ex 3

            Console.WriteLine("==========================");
            Console.WriteLine("Please eneter two numbers in order to swap between themselfs.");

            bool num7 = int.TryParse(Console.ReadLine(), out int num7Res);
            bool num8 = int.TryParse(Console.ReadLine(), out int num8Res);

            //int num7Res = 5;
            //int num8Res = 10;



            Console.WriteLine("The entered numbers are: first number: " + num7Res + ", second number: " + num8Res);

            num7Res = num7Res * num8Res;
            num8Res = num7Res / num8Res;
            num7Res = num7Res / num8Res;

            Console.WriteLine("After swap numbers are: first number: " + num7Res + ", second number: " + num8Res);

            #endregion


            Console.ReadLine();
        }
    }
}
