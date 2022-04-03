using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			new Person("Aleksandar","Peshov", 24, 'M' ),


			};

            // Task 01
            // all people aged 50 or more
            Console.WriteLine("=================== TASK 01 =====================");
			List<Person> odlerThen50 = people
									.Where(x => x.Age >= 50)
									.ToList();
			odlerThen50.ForEach(x => Console.WriteLine(x.FirstName));


			// Task 02
			// all people name starts with B
			Console.WriteLine("=================== TASK 02 =====================");

			List<Person> nameStartB = people
											.Where(x => x.FirstName.StartsWith("B"))
											.ToList();

			nameStartB.ForEach(x => Console.WriteLine(x.FirstName));


			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("=================== TASK 03 =====================");

			Person lastnameT = people
											.FirstOrDefault(x => x.LastName.StartsWith("T"));

            Console.WriteLine($"First name {lastnameT.FirstName}, last name {lastnameT.LastName}");


			// Task 04
			// find youngest and oldest person
			Console.WriteLine("=================== TASK 04 =====================");
			int minAge = people.Min(x => x.Age);
			Person youngestPerson = people
										.FirstOrDefault(x => x.Age == minAge);

			int maxAge = people.Max(x => x.Age);
			Person oldestPerson = people
										.FirstOrDefault(x => x.Age == maxAge);
            Console.WriteLine($"The oldest person is {oldestPerson.FirstName} with {maxAge} years. The youngest person is {youngestPerson.FirstName} with {minAge} years.");


			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("=================== TASK 05 =====================");
			List<Person> male45orMore = people
									.Where(x => x.Gender == 'M')
									.Where(x => x.Age >= 45)
									.ToList();
			male45orMore.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 06
			// find all females whose name starts with V
			Console.WriteLine("=================== TASK 06 =====================");
			List<string> femaleVname = people
									.Where(x => x.Gender == 'F')
									.Select(x => x.FirstName)
									.Where(x => x.StartsWith("V"))
									.ToList();
			femaleVname.ForEach(x => Console.WriteLine(x));


			// Task 07
			// find last female person older than 30 whose name starts with E
			Console.WriteLine("=================== TASK 07 =====================");
			List<Person> femaleOlder30NameP = people
											.Where(x => x.Gender == 'F' && x.Age > 30 && x.FirstName.StartsWith("E"))
											.ToList();

            femaleOlder30NameP.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 08
			// find first male younger than 40
			Console.WriteLine("=================== TASK 08 =====================");
			Person maleOlder40 = people
									.FirstOrDefault(x => x.Gender == 'M' && x.Age < 40);
            Console.WriteLine(maleOlder40.FirstName);

			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			Console.WriteLine("=================== TASK 09 =====================");
			List<Person> maleLongerFirst = people
										.Where(x => x.Gender == 'M' && x.FirstName.Count() > x.LastName.Count())
										.ToList();

			maleLongerFirst.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			Console.WriteLine("=================== TASK 10 =====================");
			List<Person> oddAgesFemale = people
									.Where(x => x.Gender == 'F' && x.Age % 2 != 0)
									.ToList();
            oddAgesFemale.ForEach(x => Console.WriteLine(x.LastName));

			Console.ReadLine();
		}

		public static void PrintList(List <Person> a)
        {
			foreach(Person person in a)
            {
                Console.WriteLine(person);
            }
        }
	}
}