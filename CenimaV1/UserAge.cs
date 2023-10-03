using System;


namespace CinemaTicketBooking
{
    public class UserAge
    {
        static DateChoice DC = new DateChoice();

        public static int userAge(string Rating, Movie MovieChosen)
        {
            int ageRating = 0;
            // gets the user to input age
            Console.WriteLine("Please Enter Your Age");

            // converts string variable Rating into int ageRating
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
                // Converts age to an int
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.Clear();
                    // Checks users age making sure they are old enough
                    if (age < ageRating)
                    {
                        // user is too young
                        Console.WriteLine("Access Denied - Too young");
                        return age;

                    }
                    else if (age >= ageRating)
                    {
                        // User the same age or older
                        Console.WriteLine("Access Granted");

                        return age;

                    }
                }
                else
                {
                    // Input could not be converted to an int
                    Console.WriteLine("Error! Please Enter Age In Numbers: ");
                    // Keeps console clear
                    Console.Clear();

                }
            }





        }
    }
}