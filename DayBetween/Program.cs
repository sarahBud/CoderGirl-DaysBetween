using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            DateTime firstDate = new DateTime(1988, 5, 4);
            DateTime secondDate = new DateTime(2019, 3, 10);

            

            Console.ReadLine();
        }

        public static int DaysBetween(DateTime firstDate, DateTime secondDate)
        {
            
            if (secondDate > firstDate)
            {
                TimeSpan difference = secondDate - firstDate;
                return difference.Days;
            }
            if (secondDate < firstDate)
            {
                TimeSpan difference = firstDate - secondDate;
                return difference.Days;
            }

            return 0;

        }
        // TODO: Create that has a method that counts the number of days between two different dates.
    }
}
