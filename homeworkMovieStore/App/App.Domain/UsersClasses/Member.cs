using App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.UsersClasses
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public string DateOfRegistration { get; set; }
        public RoleEnum Role { get; set; }

        public Member()
        {

        }

        public Member(string firstName, string lastName, int age, string username, string password, long phonenumber, string dateOfRegistration)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;  
            UserName = username;    
            Password = password;    
            PhoneNumber = phonenumber;
            DateOfRegistration = dateOfRegistration; 
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member {FirstName} {LastName}, registered on {DateOfRegistration}.");
        }


    }
}
