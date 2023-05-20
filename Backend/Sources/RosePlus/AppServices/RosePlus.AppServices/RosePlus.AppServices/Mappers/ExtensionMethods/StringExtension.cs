namespace RosePlus.AppServices.Mappers.ExtensionMethods;

public static class StringExtension
{
    public static DateTime FromString(this string? date)
    {
        return string.IsNullOrEmpty(date) 
            ? new DateTime() 
            : DateTime.ParseExact(date, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture);
    }
}