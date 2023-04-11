using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeStr = new DateTime(2015, 1, 1);
            var dateTimeNow = DateTime.Now;
            var dateTimeToday = DateTime.Today;


            // search for C# Datetime specifier format in google
            Console.WriteLine("Now to string: " + dateTimeNow.ToString("dd-MM-yy HH:mm:ss"));
            Console.WriteLine("Hour: " + dateTimeNow.Hour);
            Console.WriteLine("Minute: " + dateTimeNow.Minute);

            var dateTimeTomorrow = dateTimeNow.AddDays(1);

            Console.WriteLine("Tomorrow: " + dateTimeTomorrow);
            Console.WriteLine("Tomorrow: " + dateTimeTomorrow.ToLongDateString());
            Console.WriteLine("Tomorrow: " + dateTimeTomorrow.ToShortDateString());
            Console.WriteLine("Tomorrow: " + dateTimeTomorrow.ToLongTimeString());
            Console.WriteLine("Tomorrow: " + dateTimeTomorrow.ToShortTimeString());


            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("TimeSpan: " + timeSpan);
            Console.WriteLine("TimeSpan Total Minutes: " + timeSpan.TotalMinutes);
            Console.WriteLine("TimeSpan Total Seconds: " + timeSpan.TotalSeconds);
            Console.WriteLine("Add Minutes to time: " + timeSpan.Add(TimeSpan.FromMinutes(5)));


            // create timespan object
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("TimeSpan2 hours: " + timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration.TotalMinutes);

            //converting time span to string

            Console.WriteLine("String..: " + timeSpan.ToString());

            var timeSpanStr = "01:02:05";

            var newTimeSpan = new TimeSpan();
            newTimeSpan = TimeSpan.Parse(timeSpanStr);
            Console.WriteLine("Parse.. : " + newTimeSpan);


            //in order to update datetime, u need to use a new variable
            var dateTime = new DateTime(2015, 1, 1);

            dateTime.AddYears(1);
            
            Console.WriteLine(dateTime.Year); // will not update the original dateTime

            var newDateTime = dateTime.AddYears(1);
            Console.WriteLine(newDateTime.Year);

        }




    }
}
