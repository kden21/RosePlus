using System.Globalization;

namespace RosePlus.AppServices.Mappers.DateTimeMapper;

public static class StringExtension
{
    public static DateTime ToISOString(this string dateTime)
    {
        return DateTime.Parse(dateTime, null, DateTimeStyles.RoundtripKind);
    }
}