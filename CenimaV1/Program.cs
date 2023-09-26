using System;
using System.Collections.Generic;
using System.IO;

namespace CinemaTicketBooking
{
 

    class Program
    {
        static List<Movie> Movies= new List<Movie>();

        static void Main(string[] args)
        {
            loadUpMovies();
            welcomeMenu();
           Movie MovieChosen = movieChoice();


        }

        public static void loadUpMovies()
        { 
            Movies.Add(new Movie("Rush", "15"));
            Movies.Add(new Movie("How I Live Now", "15"));
            Movies.Add(new Movie("Thor: The Dark World", "12"));
            Movies.Add(new Movie("Filth", "18"));
            Movies.Add(new Movie("Planes", "u"));
          

        }
        public static Movie movieChoice()
        {
            Console.WriteLine("Choose Movie You Would Like To See");
            int m = 1;
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(m+": "+movie.Title + " (" + movie.Rating + ") ");
                m++;
            }
            int userMovieChoice = Convert.ToInt32(Console.ReadLine());

            if (userMovieChoice <1 || userMovieChoice>Movies.Count)
            {
                Console.WriteLine("This Movie Doesnt Exitst");
            }
            return Movies[userMovieChoice - 1];
        }
        public static void welcomeMenu()
        {
            Console.WriteLine("Welcome to Aquinas Multiplex");
            Console.WriteLine("We are presently showing:");
           
        }
        public static int userAge(string Rating)
        {
            Console.WriteLine("Please Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            //Rating = Convert.ToInt32();

            //if (age < Rating)
            //{
            //    Console.WriteLine("You Are Too Young");
            //}
            return age;
        }
    }
    class Movie
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
