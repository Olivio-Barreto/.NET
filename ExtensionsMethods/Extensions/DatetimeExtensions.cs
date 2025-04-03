using System.Globalization;

namespace ExtensionsMethods.Extensions;

public static class DatetimeExtensions
{
    public static string ElapsedTime(this DateTime obj)
    {
        var duration = DateTime.Now.Subtract(obj);

        if (duration.TotalHours < 24.0)
        {
            return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
        }
        else
        {
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
        }
    }
}
