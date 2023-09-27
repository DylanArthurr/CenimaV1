using System;


namespace CinemaTicketBooking
{
    public class Movie
    {
        public string Title = "";
        public string Rating = "";
        public int Tickets = 0;

        public static void loadUpMovies()
        {
            Program.Movies.Add(new Movie("Rush", "15"));
            Program.Movies.Add(new Movie("How I Live Now", "15"));
            Program.Movies.Add(new Movie("Thor: The Dark World", "12"));
            Program.Movies.Add(new Movie("Filth", "18"));
            Program.Movies.Add(new Movie("Planes", "U"));


        }
        public static Movie movieChoice()
        {
            Console.WriteLine("Choose Movie You Would Like To See");
            int m = 1;
            foreach (Movie movie in Program.Movies)
            {
                Console.WriteLine(m + ": " + movie.Title + " (" + movie.Rating + ") ");
                m++;
            }
            if (int.TryParse(Console.ReadLine(), out int userMovieChoice))
            {
                while (userMovieChoice < 1 || userMovieChoice > Program.Movies.Count)
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
            return Program.Movies[userMovieChoice - 1];
        }

        public Movie(string T, string R)
        {
            Title = T;
            Rating = R;
            Tickets = 0;
        }
    }
}
