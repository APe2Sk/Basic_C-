using App.Domain.Enums;
using App.Domain.UsersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class UserService
    {

        public void Register()
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
        public User FindUser(string name)
        {
            return DB.Users.FirstOrDefault(x => x.UserName == name);
        }
        public bool PassMatch(string pass)
        {
            for (int i = 0; i < 3; i++)
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

        public void CheckInfo(User user)
        {
            DateTime registertionDate = Convert.ToDateTime(user.DateOfRegistration);
            int subscribtionMonths = 1;
            if (user.TypeOfSubscription == SubscriptionEnum.MONTHLY)
            {
                Console.WriteLine($"The subscription is monthly");
            }
            else
            {
                Console.WriteLine("The subscription is annually");
                subscribtionMonths = 12;
            }
            DateTime expireDay = registertionDate.AddMonths(subscribtionMonths);
            double daysToExpire = (expireDay - DateTime.Today).Days;
            if(daysToExpire > 0)
            {
                Console.WriteLine($"The days till expiration {daysToExpire}");
            }
            else
            {
                Console.WriteLine($"Your subscription expired {daysToExpire*-1} days ago.");
            }

        }

        public void RentAMovie(User user)
        {
            SeeAllAvailableMovies();
            Console.WriteLine("Choose the movie you want to rent: (input a number of a movie)");
            bool isIntMovieRent = int.TryParse(Console.ReadLine(), out int movieRentNum);

            if(!isIntMovieRent || movieRentNum < 0 || movieRentNum > DB.Movies.Count)
            {
                throw new Exception("Input is not correct.");
            }

            Movie chosenMovie = DB.Movies.ElementAt(movieRentNum-1);

            bool endsWith;
            endsWith = chosenMovie.Title.EndsWith("*");
            if (endsWith)
            {
                throw new Exception("The movie is rented. Please choose a movie that is available at this moment.");
            }

            List<Movie> userMovies = user.Movies;
            userMovies.Add(chosenMovie);

        }

        public void SeeAllAvailableMovies()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("The movies in this store are the following:");
            int index = 1;
            foreach (Movie movie in DB.Movies)
            {
                string title = movie.Title;
                foreach (User user in DB.Users)
                {
                    foreach (Movie movieUser in user.Movies)
                    {
                        if (movieUser.Title == movie.Title)
                        {
                            title = movie.Title + "*";
                        }
                    }
                }
                Console.WriteLine($"{index}. {title}");
                index++;
            }
        }

        public void SeeRentedMovies(User user)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Movies that are rented by you: ");
            int i = 1;
            List<Movie> userMovies = user.Movies;
            foreach(Movie movie in userMovies)
            {
                Console.WriteLine($"{i}. {movie.Title}");
                i++;
            }
        }

    }
}
