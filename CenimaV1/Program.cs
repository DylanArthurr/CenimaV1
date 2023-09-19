using System;
using System.Collections.Generic;
using System.IO;

namespace CinemaTicketBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketHandling TH = new TicketHandling();   
            

            while (true)
            {
                Menue();

                MenueChoice(TH);
            }
        }

        public void SellTickets(TicketHandling TH)
        {

            TH.SellTickets();

        }
        private static void MenueChoice(TicketHandling TH)
        {
            TH.TicketChoice();
        }

        private static void Menue()
        {
            Console.WriteLine("Cinema Ticket Booking System");
            Console.WriteLine("1. Sell Tickets");
            Console.WriteLine("2. View Ticket Sales");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
        }

        


    }
}
