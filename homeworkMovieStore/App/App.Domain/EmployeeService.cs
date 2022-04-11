using App.Domain.Enums;
using App.Domain.UsersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class EmployeeService
    {


        public Employee FindEmployee(string name)
        {
            return DB.Employees.FirstOrDefault(x => x.UserName == name);
        }
        public bool PassMatch(string pass)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter password:");
                string passwordInp = Console.ReadLine();
                if (passwordInp == pass)
                {
                    return true;
                }
            }
            return false;
        }

         public void GetTheRegisteredMembers()
         {
            Console.WriteLine("Registerred users:");
            foreach (User user in DB.Users)
            {
                Console.WriteLine($"- {user.FirstName} {user.LastName}, phone number: {user.PhoneNumber}, {user.Age} years, date of registration: {user.DateOfRegistration}");
            }
         }
        public void SeeAllAvailableMovies()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("The movies in this store are the following:");
            foreach(Movie movie in DB.Movies)
            {
                string title = movie.Title;
                foreach(User user in DB.Users)
                {
                    foreach(Movie movieUser in user.Movies)
                    {
                        if(movieUser.Title == movie.Title)
                        {
                            title = movie.Title + "*";
                        }
                    }
                }
                Console.WriteLine(title);
            }
        }

        public void AddMembers()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            Console.WriteLine("====================");
            Console.WriteLine("Creating a new user...");
            Console.WriteLine("Enter first name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age:");
            bool isCorrectAgeType = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Create username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            bool isCorrectPhoneType = int.TryParse(Console.ReadLine(), out int phoneNumber);
            Console.WriteLine("Enter type of subscription (1 - monthly or 2 - annually):");
            bool isCorrectSubscribtionType = int.TryParse(Console.ReadLine(), out int subscription);
            var sub = (SubscriptionEnum)subscription; // int to enum conversion

            List<Movie> movies = new List<Movie>();

            try
            {
                if (isCorrectPhoneType || isCorrectSubscribtionType || isCorrectAgeType)
                {
                    User NewUser = new User(name, lastName, age, username, password, phoneNumber, DateTime.Today.ToString(), num, sub, movies);

                    DB.Users.Add(NewUser);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw new Exception("You did not enterred correct data. Please try again");
            }


        }

        public void DeleteMembers()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Deleting a user...");
            Console.WriteLine("Enter a name of the user to be deleted:");
            string name = Console.ReadLine();
            foreach(User user in DB.Users)
            {
                if(user.FirstName.ToLower().Trim() == name.ToLower().Trim())
                {
                    Console.WriteLine("The user was found, deleting in progress...");
                    DB.Users.Remove(user);
                    Console.WriteLine("The user was deleted.");
                    GetTheRegisteredMembers();
                }
            }
        }
    }
}
