using App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.UsersClasses
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public SubscriptionEnum TypeOfSubscription { get; set; }
        public List<Movie> Movies { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName, int age, string username, string password, long phonenumber, string dateOfRegistration, int memnerNumber, SubscriptionEnum typeOfSubscription, List<Movie> movies) : base(firstName, lastName, age, username, password, phonenumber, dateOfRegistration)
        {
            MemberNumber = memnerNumber;
            Role = RoleEnum.USER;
            TypeOfSubscription = typeOfSubscription;
            Movies = movies;
        }


    }
}
