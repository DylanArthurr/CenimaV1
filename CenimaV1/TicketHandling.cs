using CinemaTicketBooking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketBooking
{
    class TicketHandling
    {

        public TicketHandling() {

            string filePath = "ticket_sales.txt";

            LoadFile(movies, filePath);
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

        public List<Movie> movies= new List<Movie>();   
        public  void SellTickets()
        {
            int movieIndex = -1;
            int quantity  = 0;

            Console.WriteLine("Movies Available:");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Title}");
            }

            Console.Write("Enter the movie number: ");
            if (int.TryParse(Console.ReadLine(), out  movieIndex) && movieIndex >= 1 && movieIndex <= movies.Count)
            {
                Console.Write("Enter the number of tickets to sell: ");
                if (int.TryParse(Console.ReadLine(), out  quantity) && quantity >= 0)
                {
                    movies[movieIndex].SellTickets(quantity);
                    Console.WriteLine($"Sold {quantity} tickets for {movies[movieIndex - 1].Title}");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please enter a non-negative number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid movie number. Please select a valid movie.");
            }
        }

         void ViewTicketSales(List<Movie> movies)
        {
            Console.WriteLine("Ticket Sales:");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title}: {movie.TicketsSold} tickets sold");
            }
        }

         void SaveTicketSales(string filePath, List<Movie> movies)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Movie movie in movies)
                {
                    writer.WriteLine($"{movie.Title},{movie.TicketsSold}");
                }
            }
        }

        public  void TicketChoice(List<Movie> movies, string filePath)
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        SellTickets(movies);
                        break;
                    case 2:
                        ViewTicketSales(movies);
                        break;
                    case 3:
                        // Save data to the file before exiting
                        SaveTicketSales(filePath, movies);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        public void SellTickets(int quantity)
        {
            TicketsSold += quantity;
        }
    }
}
