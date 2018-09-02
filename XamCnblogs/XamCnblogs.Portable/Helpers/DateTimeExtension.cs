using System;

namespace XamCnblogs.Portable.Helpers
{
    public static class DateTimeExtension
    {
        public static string Format(this DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;
            if (span.TotalDays > 30)
            {
                if (DateTime.Now.Year > dt.Year)
                {
                    return dt.ToString("yyyy-M-d");
                }
                else
                {
                    return dt.ToString("M-d");
                }
            }
            else
            {
                return span.Format();
            }
        }

        public static string Format(this TimeSpan span)
        {
            if (span.TotalDays > 1)
            {
                return string.Format("{0} Days Ago", (int)Math.Floor(span.TotalDays));
            }
            else if (span.TotalHours > 1)
            {
                return string.Format("{0} Hours Ago", (int)Math.Floor(span.TotalHours));
            }
            else if (span.TotalMinutes > 1)
            {
                return string.Format("{0} Minute Ago", (int)Math.Floor(span.TotalMinutes));
            }
            else if (span.TotalSeconds > 5)
            {
                return string.Format("{0} Second Ago", (int)Math.Floor(span.TotalSeconds));
            }
            else
            {
                return "Just Now";
            }
        }
    }
}
