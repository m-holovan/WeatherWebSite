using Microsoft.AspNetCore.Http;

namespace WeatherApplication.Models
{
    public static class DateHelper
    {
        public static DayOfWeek GetDayOfWeek(string dateString)
        {
            DateTime date;
            try
            {
                date = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
                DayOfWeek dayOfWeek = GetDayOfWeek(date);
                Console.WriteLine($"The day of the week for {date.ToShortDateString()} is {dayOfWeek}");
                return dayOfWeek;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format");
                return DayOfWeek.Saturday;
            }
        }

        static DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }
    }
}
