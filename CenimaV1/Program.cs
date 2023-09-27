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
            int ageRating = userAge(MovieChosen.Rating);
            DateTime selectedDate = dateChoice(Movie movie);
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
            if(int.TryParse(Console.ReadLine(), out int userMovieChoice))
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
        public static int userAge(string Rating)
        {
            int ageRating = 0;
            Console.WriteLine("Please Enter Your Age");

            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out int age))

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



                if (age < ageRating)
                {
                    Console.WriteLine("Access Denied - Too young");
                    
                }
                else if (age >= ageRating)
                {
                    Console.WriteLine("Access Granted");
                    DateTime selectedDate = dateChoice(Movie movie);
                }
                else
                {
                    Console.WriteLine("Error! Please Enter Age In Numbers!");                  
                    Console.Clear();
                }
                return age;





            }


        }

        public static DateTime dateChoice(Movie movie)
        {
            Console.WriteLine("Please Enter The Date: ");
            DateTime selectedDate;

            while (true)
            {
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out selectedDate))
                {
                    Console.Clear();
                    Console.WriteLine($"--------------------\r\nAquinas Multiplex\r\nFilm : {movie.Title}\r\nDate : {selectedDate}\r\nEnjoy the film\r\n--------------------");
                    break;
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
