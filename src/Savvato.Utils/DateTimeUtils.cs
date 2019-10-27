namespace Savvato.Utils
{
    using System;

    public static class DateTimeUtils
    {
        public static DateTime ToEndOfDay(this DateTime sourceDateTime)
        {
            return new DateTime(
                year: sourceDateTime.Year,
                month: sourceDateTime.Month,
                day: sourceDateTime.Day,
                hour: 23,
                minute: 59,
                second: 59,
                millisecond: 999);
        }
        
        public static DateTime ToBeginOfDay(this DateTime sourceDateTime)
        {
            return new DateTime(
                year: sourceDateTime.Year,
                month: sourceDateTime.Month,
                day: sourceDateTime.Day,
                hour: 0,
                minute: 0,
                second: 0,
                millisecond: 0);
        }
    }
}
