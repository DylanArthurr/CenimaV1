using System;


namespace CinemaTicketBooking
{
    public class UserAge
    {
        static DateChoice DC = new DateChoice();

        public static int userAge(string Rating, Movie MovieChosen)
        {
            int ageRating = 0;

            Console.WriteLine("Please Enter Your Age");

            switch (Rating)
            {
                case "U":
                    ageRating = 0;
                    break;
                case "15":
                    ageRating = 15;
                    break;
                case "12":
                    ageRating = 12;
                    break;
                case "18":
                    ageRating = 18;
                    break;

            }

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.Clear();

                    if (age < ageRating)
                    {
                        Console.WriteLine("Access Denied - Too young");
                        return age;

                    }
                    else if (age >= ageRating)
                    {
                        Console.WriteLine("Access Granted");

                        return age;

                    }
                }
                else
                {
                    Console.WriteLine("Error! Please Enter Age In Numbers: ");
                    Console.Clear();

                }
            }





        }
    }
}
