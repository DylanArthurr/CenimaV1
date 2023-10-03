
using System;
using System.Collections.Generic;


namespace CinemaTicketBooking
{


    class Program
    {
        // Creates an object for DataChoice
        static DateChoice DC = new DateChoice();
        public static List<Movie> Movies = new List<Movie>();

        static void Main(string[] args)
        {
            //Loads the movie list
            Movie.loadUpMovies();
            // loops the program
            while (true)
            {
                // Calls all of the funtions
                Welcome.welcomeMenu();
                // user chooses movie
                Movie MovieChosen = Movie.movieChoice();
                // Tickets sold is accounted for
                TicketSystem.TicketsSold(MovieChosen);
                // Age is checked
                int ageRating = UserAge.userAge(MovieChosen.Rating, MovieChosen);
                // Date and time of the movie is selected
                DateTime selectedDate = DC.dateChoice(MovieChosen);
                // Asks if the user would wish to continue with using the program
                Console.WriteLine("Contunie?: 'y' 'n' ");
                if (Console.ReadLine() == "y")
                {
                    // Clears console once user wanted to continue
                    Console.Clear();
                    // Continues through while loop again
                    continue;
                }
                else
                {
                    // Closes the program
                    Environment.Exit(0);
                }

            }

        }





    }
}

