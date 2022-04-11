using App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.UsersClasses
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public GenreEnum Genre { get; set; }
        private int Price { get; set; }

        public Movie()
        {

        }
        
        public Movie(string title, string description, int year, GenreEnum genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }

        public int SetPrice(int year)
        {
            Random rnd = new Random();
            if (year < 2000)
            {
                return rnd.Next(100, 200); 
            }
            else if (year >= 2000 && year < 2010)
            {
                return rnd.Next(200, 300);
            }
            else
            {
                return rnd.Next(300, 500);
            }
        }


    }
}
