namespace CinemaTicketBooking
{
    public class Movie
    {
        public string Title { get; set; }
        public int TicketsSold { get; set; }

        public Movie(string title)
        {
            Title = title;
            TicketsSold = 0;
        }

        public void SellTickets(int q)
        {

        }

    }
}
