using App.Domain.Enums;
using App.Domain.UsersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public static class DB
    {

        public static List<Movie> Movies = new List<Movie>
        {
            new Movie ("Titanic", "Seventeen-year-old Rose hails from an aristocratic family and is set to be married. When she boards the Titanic, she meets Jack Dawson, an artist, and falls in love with him.", 1997, GenreEnum.ROMANCE),
            new Movie ("The Batman", "Batman ventures into Gotham City's underworld when a sadistic killer leaves behind a trail of cryptic clues. As the evidence begins to lead closer to home and the scale of the perpetrator's plans become clear, he must forge new relationships, unmask the culprit and bring justice to the abuse of power and corruption that has long plagued the metropolis.", 2022, GenreEnum.ACTION),
            new Movie ("Spider-Man: No Way Home", "With Spider-Man's identity now revealed, our friendly neighborhood web-slinger is unmasked and no longer able to separate his normal life as Peter Parker from the high stakes of being a superhero. When Peter asks for help from Doctor Strange, the stakes become even more dangerous, forcing him to discover what it truly means to be Spider-Man.", 2021, GenreEnum.ACTION),
            new Movie ("Death on the Nile", "Belgian sleuth Hercule Poirot's Egyptian vacation aboard a glamorous river steamer turns into a terrifying search for a murderer when a picture-perfect couple's idyllic honeymoon is tragically cut short.", 2022, GenreEnum.MYSTERY),
            new Movie ("Avengers: Endgame", "After Thanos, an intergalactic warlord, disintegrates half of the universe, the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore balance.", 2019, GenreEnum.ACTION),
            new Movie ("The Irishman", "In the 1950s, truck driver Frank Sheeran gets involved with Russell Bufalino and his Pennsylvania crime family. As Sheeran climbs the ranks to become a top hit man, he also goes to work for Jimmy Hoffa -- a powerful Teamster tied to organized crime.", 2019, GenreEnum.CRIME),
            new Movie ("The Shawshank Redemption", "Andy Dufresne, a successful banker, is arrested for the murders of his wife and her lover, and is sentenced to life imprisonment at the Shawshank prison. He becomes the most unconventional prisoner.", 1994, GenreEnum.DRAMA),
            new Movie ("Live and Let Die", "James Bond is sent to New York to investigate the mysterious deaths of British agents. On his journey, he meets a voodoo master and a tarot card reader.", 1973, GenreEnum.ACTION),
            new Movie ("No Time to Die", "James Bond is enjoying a tranquil life in Jamaica after leaving active service. However, his peace is short-lived as his old CIA friend, Felix Leiter, shows up and asks for help. The mission to rescue a kidnapped scientist turns out to be far more treacherous than expected, leading Bond on the trail of a mysterious villain who's armed with a dangerous new technology.", 2021, GenreEnum.ACTION),
            new Movie ("21 Jump Street", "Schmidt and Jenko are high school friends who go on to become police officers. The two friends go undercover as students in order to bust a drug ring and find the source of a synthetic drug.", 2012, GenreEnum.COMEDY),
            new Movie ("Dumb & Dumber", "Two good-hearted but incredibly stupid friends stumble upon a briefcase. Unknown to them, it contains money that is intended for abductors with connections to the mob.", 1994, GenreEnum.COMEDY),
            new Movie ("Deadpool", "Ajax, a twisted scientist, experiments on Wade Wilson, a mercenary, to cure him of cancer and give him healing powers. However, the experiment leaves Wade disfigured and he decides to exact revenge.", 2016, GenreEnum.ADVENTURE),
            new Movie ("Grown Ups", "Five childhood friends take their families for a weekend trip to a lake house in their hometown, where they reunite to attend the funeral of their former high school basketball coach.", 2010, GenreEnum.COMEDY),

        };

        public static List<User> Users = new List<User>
        {
            new User("Aleksandar", "Peshov",24, "apeshov", "123", 075470586, "01/04/2022", 36985231, SubscriptionEnum.ANNUALLY, new List<Movie>
            {
                
                Movies[7],
                Movies[3],
                Movies[9],

            }),
            new User("Angel", "Mitrov",21, "amitrov", "123", 05632126, "10/04/2022", 11365974, SubscriptionEnum.MONTHLY, new List<Movie>
            {
                Movies[0],
                Movies[5],
                Movies[4]

            }),
            new User("Petre", "Arsovski",28, "parsovski", "123", 424375757, "03/02/2022", 3355714, SubscriptionEnum.ANNUALLY, new List<Movie>
            {
                Movies[2],
                Movies[6]

            }),
            new User("Laze", "Gorgiev", 22, "lgorgiev", "123", 61974653, "01/01/2022", 336697412, SubscriptionEnum.MONTHLY, new List<Movie>
            {
                Movies[12]
            }),


        };

        public static List<Employee> Employees = new List<Employee>
        {
            new Employee("Bob", "Bobski", 23, "bbski", "1234", 9874126987, "01/02/2022", 120),
            new Employee("Kelsey", "Bobski", 22, "kbski", "1234", 318965216987, "01/06/2021", 170)
        };

    }
}
