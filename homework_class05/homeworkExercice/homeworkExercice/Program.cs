using homeworkExercice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            string raceAgain = "Yes";
            do
            {
                string[][] choices = new string[2][];

                choices[0] = Choice();
                choices[1] = Choice();

                string car1 = choices[0][0];
                string driver1 = choices[0][2];
                string car2 = choices[1][0];
                string driver2 = choices[1][2];


                //int[] resultsRace = new int[2];
                int[] resultsRace1 = ProcessAndInput(car1, driver1, car2, driver2);



                int resultOfRace = RaceCars(resultsRace1);

                Winner(choices, resultOfRace);


                //foreach(int res in resultsRace1)
                //{
                //    Console.WriteLine(res);
                //}

                Console.WriteLine("=====================================================");

                Console.WriteLine("Do you want to race again? (yes or no)");
                raceAgain = Console.ReadLine().ToLower();

            }
            while (raceAgain != "no");



            Console.ReadLine();

        }

        static string[] Choice()
        {
            // asking the user in the console for the first time
            Console.WriteLine("Choose the car number 1: 1. Hyundai, 2. Mazda, 3. Ferrari or 4. Porsche");
            string[] choice1 = new string[4];
            choice1[0] = Console.ReadLine();

            if(choice1[0] == "1" || choice1[0] == "2" || choice1[0] == "3" || choice1[0] == "4")
            {
                switch(choice1[0]) 
                {
                                case "1":
                                    choice1[1] = "Hyundai";
                                    break;
                                case "2":
                                    choice1[1] = "Mazda";
                                    break;
                                case "3":
                                    choice1[1] = "Ferrari";
                                    break;
                                case "4":
                                    choice1[1] = "Porsche";
                                    break;
                                default:
                                    Console.WriteLine("You must enter a number between 1 and 4");
                                    break;
                }
            }

                       
            Console.WriteLine("Choose the driver number 1: 1. Aleksandar, 2. Antonio, 3. Hristijan or 4. Laze");
            choice1[2] = Console.ReadLine();

            if (choice1[2] == "1" || choice1[2] == "2" || choice1[2] == "3" || choice1[2] == "4")
            {
                switch (choice1[2])
                {
                    case "1":
                        choice1[3] = "Aleksandar";
                        break;
                    case "2":
                        choice1[3] = "Antonio";
                        break;
                    case "3":
                        choice1[3] = "Hristijan";
                        break;
                    case "4":
                        choice1[3] = "Laze";
                        break;
                    default:
                        Console.WriteLine("You must enter a number between 1 and 4");
                        break;
                }
            }

            bool isvalidated1 = int.TryParse(choice1[0], out int res1);
            bool isvalidated2 = int.TryParse(choice1[2], out int res2);

            if(!isvalidated1 || !isvalidated2)
            {
                string[] x = new string[0];
                x[0] = "You entered error number.";
                Console.WriteLine(x[0]);
                return x;
            }

            if(res1 != 1 || res1 != 2 || res1 != 3 || res1 != 4)
            {
                string[] x = new string[0];
                x[0] = "You entered error number.";
                Console.WriteLine(x[0]);
                return x;
            }


            return choice1;
        }

        static int[] ProcessAndInput(string car1, string driver1, string car2, string driver2)
        {
            // creation of driver objects
            Driver aleksandar = new Driver("Aleksandar", 8);
            Driver antonio = new Driver("Antonio", 9);
            Driver hristijan = new Driver("Hristijan", 5);
            Driver laze = new Driver("Laze", 4);
            //Console.WriteLine(aleksandar.Name);
            //Console.WriteLine(aleksandar.Skill);

            Driver[] names = new Driver[4];
            names[0] = aleksandar;
            names[1] = antonio;
            names[2] = hristijan;
            names[3] = laze;

            // creation of Car objects
            Car[] carNames = new Car[4];

            Car hyundai = new Car();
            hyundai.Model = "Hyundai";
            hyundai.Speed = 150;
            carNames[0] = hyundai;

            Car mazda = new Car();
            mazda.Model = "Mazda";
            mazda.Speed = 110;
            carNames[1] = mazda;


            Car ferrari = new Car();
            ferrari.Model = "Ferrari";
            ferrari.Speed = 260;
            carNames[2] = ferrari;

            Car porche = new Car();
            porche.Model = "Porsche";
            porche.Speed = 230;
            carNames[3] = porche;

            int[] results = new int[2];

            // asking the user in the console for the first time
            //Console.WriteLine("Choose the car number 1: 1. Hyundai, 2. Mazda, 3. Ferrari or 4. Porsche");
            bool isSuccesCar1 = int.TryParse(car1, out int resultCar1);

            //Console.WriteLine("Choose the driver number 1: 1. Aleksandar, 2. Antonio, 3. Hristijan or 4. Laze");
            bool isSuccessDriver1 = int.TryParse(driver1, out int resultDriver1);

            if (isSuccesCar1 && isSuccessDriver1)
            {
                carNames[resultCar1 - 1].Driver = names[resultDriver1 - 1].Name;
                int result1 = carNames[resultCar1 - 1].CalculateSpeed(names[resultDriver1 - 1].Skill);
                //Console.WriteLine(carNames[resultCar-1].Model);
                //Console.WriteLine(names[resultDriver-1].Name);
                Console.WriteLine(result1);
                results[0] = result1;
            }


            // asking the user in the console for the second time
            //Console.WriteLine("Choose the car number 1: 1. Hyundai, 2. Mazda, 3. Ferrari or 4. Porsche");
            bool isSuccesCar2 = int.TryParse(car2, out int resultCar2);

            //Console.WriteLine("Choose the driver number 1: 1. Aleksandar, 2. Antonio, 3. Hristijan or 4. Laze");
            bool isSuccessDriver2 = int.TryParse(driver2, out int resultDriver2);

            if (isSuccesCar2 && isSuccessDriver2)
            {
                carNames[resultCar2 - 1].Driver = names[resultDriver2 - 1].Name;
                int result2 = carNames[resultCar2 - 1].CalculateSpeed(names[resultDriver2 - 1].Skill);
                //Console.WriteLine(carNames[resultCar-1].Model);
                //Console.WriteLine(names[resultDriver-1].Name);
                Console.WriteLine(result2);
                results[1] = result2;
            }
            return results;
        }

        static int RaceCars(int[] raceRes1)
        {
            if(raceRes1[0] > raceRes1[1])
            {
                Console.WriteLine("car no 1 is faster");
                return 0;
            }
            else if (raceRes1[1] > raceRes1[0])
            {
                Console.WriteLine("car no 2 is faster");
                return 1;
            }
            else
            {
                Console.WriteLine("They are equal");
                return -1;
            }
        }

        static string Winner(string[][] winner, int winnerNUm)
        {
            Console.WriteLine(".................................................");

            switch (winnerNUm)
            {
                case 0:
                    Console.WriteLine($"The winner is {winner[0][3]} with the vehicle {winner[0][1]}");
                    break;
                case 1:
                    Console.WriteLine($"The winner is {winner[1][3]} with the vehicle {winner[1][1]}");
                    break;
                case -1:
                    Console.WriteLine($"The winner isn't any winner, {winner[0][3]} and {winner[1][3]} are equal in the race.");
                    break;
                default:
                    Console.WriteLine("There is a mistake");
                    break;
            }
            return "Error";
        }
    }
}
