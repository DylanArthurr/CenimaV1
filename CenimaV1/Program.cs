using System;
using System.Collections.Generic;
using System.IO;

namespace CinemaTicketBooking
{


    class Program
    {
        static List<Movie> Movies = new List<Movie>();

        static void Main(string[] args)
        {
            welcomeMenu();
            Movie MovieChosen = movieChoice();
            int ageRating = userAge(MovieChosen.Rating, MovieChosen);

            Console.ReadLine();

        }

        public static void loadUpMovies()
        {
            Movies.Add(new Movie("Rush", "15"));
            Movies.Add(new Movie("How I Live Now", "15"));
            Movies.Add(new Movie("Thor: The Dark World", "12"));
            Movies.Add(new Movie("Filth", "18"));
            Movies.Add(new Movie("Planes", "U"));


        }
        public static Movie movieChoice()
        {
            Console.WriteLine("Choose Movie You Would Like To See");
            int m = 1;
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(m + ": " + movie.Title + " (" + movie.Rating + ") ");
                m++;
            }
            if (int.TryParse(Console.ReadLine(), out int userMovieChoice))
            {
                while (userMovieChoice < 1 || userMovieChoice > Movies.Count)
                {
                    Console.WriteLine("This Movie Doesnt Exitst");
                    Console.WriteLine("Please Enter Another Number: ");
                    userMovieChoice = Convert.ToInt32(Console.ReadLine());
                }

            }
            else
            {

                Console.WriteLine("Error! Please Enter Movie Selection In Numbers: ");

                userMovieChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            return Movies[userMovieChoice - 1];
        }
        public static void welcomeMenu()
        {
            Console.WriteLine("Welcome to Aquinas Multiplex");
            Console.WriteLine("We are presently showing:");
            loadUpMovies();

        }
        public static int userAge(string Rating, Movie MovieChosen)
        {
            int ageRating = 0;

            Console.WriteLine("Please Enter Your Age");



            switch (Rating)
            {
                case "U":
                    ageRating = 0;
                    break;
                case "15":
                    ageRating = 15;
                    break;
                case "12":
                    ageRating = 12;
                    break;
                case "18":
                    ageRating = 18;
                    break;

            }

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.Clear();

                    if (age < ageRating)
                    {
                        Console.WriteLine("Access Denied - Too young");
                        return age;

                    }
                    else if (age >= ageRating)
                    {
                        Console.WriteLine("Access Granted");
                        DateTime selectedDate = dateChoice(MovieChosen);
                        return age;

                    }
                }
                else
                {
                    Console.WriteLine("Error! Please Enter Age In Numbers: ");
                    Console.Clear();

                }
            }





        }

        public static DateTime dateChoice(Movie movie)
        {
            Console.WriteLine("Please Enter The Date (yyyy-MM-dd, within the next week): ");
            DateTime selectedDate;
            DateTime selectedTime;
            DateTime currentDate = DateTime.Now;
            DateTime maxDate = currentDate.AddDays(7); // Maximum date allowed is 7 days in the future

            while (true)
            {
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out selectedDate))
                {
                    if (selectedDate >= currentDate && selectedDate <= maxDate)
                    {
                        Console.WriteLine("Please Enter Time (hh:mm): ");
                        if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out selectedTime))
                        {
                            Console.Clear();
                            Console.WriteLine($"--------------------\r\nAquinas Multiplex\r\nFilm : {movie.Title}\r\nDate : {selectedDate:yyyy-MM-dd} {selectedTime:HH:mm}\r\nRating : {movie.Rating}\r\nEnjoy the film!\r\n--------------------");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Time");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid date. Please enter a date within the next week.");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid Date");
                }
            }

            return selectedDate;
        }




        public class Movie
        {
            public string Title = "";
            public string Rating = "";
            public int Tickets = 0;

            public Movie(string T, string R)
            {
                Title = T;
                Rating = R;
                Tickets = 0;
            }
        }
    }
}
