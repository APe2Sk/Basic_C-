using App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.UsersClasses
{
    public class Employee : Member
    {
        private double Salary { get; set; }
        public double HoursPerMonth { get; set; }
        public Nullable<double> Bonus { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, int age, string username, string password, long phonenumber, string dateOfRegistration, int hoursPerMonth) : base(firstName, lastName, age, username, password, phonenumber, dateOfRegistration)
        {
            Salary = 300.00;
            HoursPerMonth = hoursPerMonth;
            Role = RoleEnum.EMPLOYEE;
            Bonus = SetBonus(hoursPerMonth);
            Salary = SetSalary();
        }

        public Nullable<double> SetBonus(int workingHours)
        {
            if (workingHours > 160)
            {
                return Salary * 0.3;
            }
            return null;
        }

        public double SetSalary()
        {
            if (Bonus != null)
            {
                return Salary + Bonus.Value;
            }
            return Salary;
        }
    }
}
