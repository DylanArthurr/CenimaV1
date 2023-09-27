using System;


namespace CinemaTicketBooking
{
    class Welcome
    {
        public static void welcomeMenu()
        {
            Console.WriteLine("Welcome to Aquinas Multiplex");
            Console.WriteLine("We are presently showing:");
            Movie.loadUpMovies();
        }
    }
}
