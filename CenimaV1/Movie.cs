using System;


namespace CinemaTicketBooking
{
    public class Movie
    {
        public string Title = "";
        public string Rating = "";
        public int Tickets = 0;

        public int TicketsSold {  get; set; }


        public static void loadUpMovies()
        {
            // Add all these movies to the Movie list
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
            // Goes through the movie list 
            foreach (Movie movie in Program.Movies)
            {
                //Prints all the movies
                Console.WriteLine(m + ": " + movie.Title + " (" + movie.Rating + ") ");
                m++;
            }
            // takes the users input and assignes it to userMovieChoise
            if (int.TryParse(Console.ReadLine(), out int userMovieChoice))
            {
                //While the user enters the wrong number allow them to enter another
                while (userMovieChoice < 1 || userMovieChoice > Program.Movies.Count)
                {
                    Console.WriteLine("This Movie Doesnt Exitst");
                    Console.WriteLine("Please Enter Another Number: ");
                    userMovieChoice = Convert.ToInt32(Console.ReadLine());
                }

            }
            else
            {
                //if the input isnt an integer 
                Console.WriteLine("Error! Please Enter Movie Selection In Numbers: ");
                // Takes users input again converting it into an int
                userMovieChoice = Convert.ToInt32(Console.ReadLine());
                // clears console to keep clean
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