using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkFromClass03
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercice 6 form class

                string[] names = new string[10];

                for(int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("Please enter a name: ");
                    names[i] = Console.ReadLine();

                    Console.WriteLine("Do you want to continue inputting a names? (Y / N)");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "N")
                    {
                        break;
                    }
                }

                Console.WriteLine("You entered the following names: ");
                foreach(string name in names)
                {
                    Console.WriteLine(name);
                }

            #endregion


            #region Homework ex 1 - SumOfEven
            Console.WriteLine("------------------- HW ex 2----------------");

            Console.WriteLine("Please enter 6 numbers.");


            int[] arrInt = new int[6];
            
            for(int i = 0; i < arrInt.Length; i++)
            {
                bool isNUmber = int.TryParse(Console.ReadLine(), out int inputNum);

                if (isNUmber)
                {
                    arrInt[i] = inputNum;
                }
            }

            int sumOfEven = 0;

            foreach(int number in arrInt)
            {
                if(number % 2 ==0)
                {
                    sumOfEven += number;
                }
            }

            Console.WriteLine("The sum of even numbers in the array is:" + sumOfEven);


            #endregion


            #region Homework ex 2 - StudentGroup

            Console.WriteLine("-------------------- HW EX 2 -----------------");
            string[] studentsG1 = { "Aleksandar", "Hristijan", "Laze", "Filip", "Ivan" };
            string[] studentsG2 = { "Goce", "Angel", "Petre", "Sara", "Filip" };

            // print the array by the wish of the user
            Console.WriteLine("There are two arrays of students, which would you like to ptint in the console? (please enter: 1 or 2)");
            bool ifCorrectInput = int.TryParse(Console.ReadLine(), out int whichArrToPrint);

            if(ifCorrectInput)
            {
                switch(whichArrToPrint)
                {
                    case 1:
                        foreach(string name in studentsG1)
                        {
                            Console.WriteLine(name);
                        }
                        break;
                    case 2:
                        foreach (string name in studentsG2)
                        {
                            Console.WriteLine(name);
                        }
                        break;
                    default:
                        Console.WriteLine("You did not entered a correct number in order to print. Please try again and enter number of array to be printed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not entered a number of array to be printed. Please enter a number of array to be printed. (please enter: 1 or 2)");
            }

            Console.ReadLine();


            #endregion

            Console.ReadLine();
        }
    }
}
