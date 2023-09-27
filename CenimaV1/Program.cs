
using System;
using System.Collections.Generic;


namespace CinemaTicketBooking
{


    class Program
    {
        static DateChoice DC = new DateChoice();
        public static List<Movie> Movies = new List<Movie>();

        static void Main(string[] args)
        {
            Welcome.welcomeMenu();
            Movie MovieChosen = Movie.movieChoice();
            int ageRating = UserAge.userAge(MovieChosen.Rating, MovieChosen);
            DateTime selectedDate = DC.dateChoice(MovieChosen);
            Console.ReadLine();
        }

        

        

       





    }
}
