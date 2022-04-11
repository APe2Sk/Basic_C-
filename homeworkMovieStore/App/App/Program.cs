// See https://aka.ms/new-console-template for more information


using App.Domain;
using App.Domain.UsersClasses;

EmployeeService employeeService = new EmployeeService();
UserService userService = new UserService();    


try
{

    Console.WriteLine("====================================");
    Console.WriteLine("Type USER if you are user or type EMPLOYEE if you are employee in order to log in.");
    string memberLogIn = Console.ReadLine();

    if(memberLogIn.Trim().ToLower() == "user")
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Do you have an account? (Yes / No)");
        string accountExist = Console.ReadLine(); 
        if(accountExist.ToLower().Trim() == "no")
        {
            userService.Register();
        }
        Console.WriteLine("Log in");
        Console.WriteLine("====================================");
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();


        if (string.IsNullOrEmpty(username))
        {
            throw new Exception("You must enter username");
        }

        User logInUser = userService.FindUser(username);
        bool userNameTrue = false;
        for(int i = 0; i < 2; i++)
        {
            logInUser = userService.FindUser(username);

            if (logInUser != null)
            {
                userNameTrue = true;
                break;
            }
            else
            {
                userNameTrue = false;
                Console.WriteLine("Wrong username. Please try again.");
                username = Console.ReadLine();
            }
        }
        if (!userNameTrue)
        {
            throw new Exception("You did not eterred a valid username.");
        }


        if (userNameTrue)
        {
            bool passMatch = userService.PassMatch(logInUser.Password);

            if (!passMatch)
            {
                throw new Exception("Password did not match 3 times. Please try again later.");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("Wellcome our dear user! You logged in successfully!");
            Console.WriteLine("===================================");
        }
        userService.CheckInfo(logInUser);
        userService.RentAMovie(logInUser);
        userService.SeeRentedMovies(logInUser);

    }
    else if(memberLogIn.Trim().ToLower() == "employee")
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();


        if (string.IsNullOrEmpty(username))
        {
            throw new Exception("You must enter username");
        }

        Employee logInEmlpoyee = employeeService.FindEmployee(username);

        if (logInEmlpoyee == null)
        {
            throw new Exception("Invalid username, please try again");
        }

        if (logInEmlpoyee != null)
        {
            bool passMatch = employeeService.PassMatch(logInEmlpoyee.Password);

            if (!passMatch)
            {
                throw new Exception("Password did not match 3 times. Please try again later.");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("Wellcome our employee! You logged in successfully!");
            Console.WriteLine("===================================");

        }

        employeeService.GetTheRegisteredMembers();
        employeeService.SeeAllAvailableMovies();
        employeeService.AddMembers();
        employeeService.GetTheRegisteredMembers();
        employeeService.DeleteMembers();

    }
    else
    {
        Console.WriteLine("You did not entered what type of member you are. Please try again.");
    }


    

}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}



Console.ReadLine();
