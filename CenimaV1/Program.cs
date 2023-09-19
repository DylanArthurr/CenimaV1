using System;
using System.Collections.Generic;
using System.IO;

namespace CinemaTicketBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            string filePath = "ticket_sales.txt";

            LoadFile(movies, filePath);

            while (true)
            {
                Menue();

                MenueChoice(movies, filePath);
            }
        }

        public void SellTickets()
        {
            TicketHandling.SellTickets(movies, movieIndex - 1, quantity);

        }
        private static void MenueChoice(List<Movie> movies, string filePath)
        {
            TicketChoice(movies, filePath);
        }

        private static void Menue()
        {
            Console.WriteLine("Cinema Ticket Booking System");
            Console.WriteLine("1. Sell Tickets");
            Console.WriteLine("2. View Ticket Sales");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
        }

        private static void LoadFile(List<Movie> movies, string filePath)
        {
            // Load existing data from the file, if it exists
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string title = parts[0];
                        int ticketsSold = int.Parse(parts[1]);
                        movies.Add(new Movie(title) { TicketsSold = ticketsSold });
                    }
                }
            }
        }


    }
}
