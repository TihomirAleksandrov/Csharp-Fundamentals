using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();
        var startDate = DateTime.ParseExact(date1,
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(date2,
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}
