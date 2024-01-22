using System.Globalization;

namespace RosePlus.AppServices.Mappers.DateTimeMapper;

public static class DateTimeExtension
{
    public static string ToISOString(this DateTime dateTime)
    {
        return dateTime.ToString("o", CultureInfo.InvariantCulture);
    }
}