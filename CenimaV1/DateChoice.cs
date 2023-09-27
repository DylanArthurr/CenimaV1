using System;


namespace CinemaTicketBooking
{
    public class DateChoice
    {
        public DateTime dateChoice(Movie movie)
        {
            Console.WriteLine("Please Enter The Date (yyyy-MM-dd, within the next week): ");
            DateTime selectedDate;
            DateTime selectedTime;
            DateTime currentDate = DateTime.Now;
            DateTime maxDate = currentDate.AddDays(7); // Maximum date allowed is 7 days in the future

            while (true)
            {
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out selectedDate))
                {
                    if (selectedDate >= currentDate && selectedDate <= maxDate)
                    {
                        Console.WriteLine("Please Enter Time (hh:mm): ");
                        if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out selectedTime))
                        {
                            Console.Clear();
                            Console.WriteLine($"--------------------\r\nAquinas Multiplex\r\nFilm : {movie.Title}\r\nDate : {selectedDate:yyyy-MM-dd} {selectedTime:HH:mm}\r\nRating : {movie.Rating}\r\nEnjoy the film!\r\n--------------------");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Time");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid date. Please enter a date within the next week.");
                    }


                }
                else
                {
                    Console.WriteLine("Invalid Date");
                }
            }

            return selectedDate;
        }
    }
}
