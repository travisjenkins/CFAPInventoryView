using System.Reflection;

namespace CFAPInventoryView
{
    public static class HelperMethods
    {
        public static string DisplaySafeString<T>(T displayString)
        {
            if (displayString is null) return string.Empty;

            if (displayString.GetType() == typeof(string))
            {
                return displayString as string ?? string.Empty;
            }
            if (displayString.GetType() == typeof(int))
            {
                return string.Format("{0:0}", displayString);
            }
            if (displayString.GetType() == typeof(double))
            {
                return string.Format("{0:0.0}", displayString);
            }
            if (displayString.GetType() == typeof(decimal))
            {
                return string.Format("{0:0.00}", displayString);
            }
            return displayString.ToString() ?? string.Empty;
        }

        public static DateTime? CombineDateAndTimeInputFields(DateTime? date, DateTime? time)
        {
            if (!date.HasValue && !time.HasValue) return null;
            if (!DateTime.TryParse(date?.ToShortDateString(), out DateTime propertyDate)) return null;
            if (!DateTime.TryParse(time?.ToShortTimeString(), out DateTime propertyTime)) return null;

            return new DateTime(propertyDate.Year, propertyDate.Month, propertyDate.Day, propertyTime.Hour, propertyTime.Minute, propertyTime.Second);
        }

        public static void UpdateEntityProperties<T1, T2>(T1 entityToUpdate, T2 entityWithUpdates)
        {
            if (entityToUpdate != null && entityWithUpdates != null)
            {
                foreach (PropertyInfo prop in entityWithUpdates.GetType().GetProperties())
                {
                    entityToUpdate.GetType().GetProperty(prop.Name)?.SetValue(entityToUpdate, prop.GetValue(entityWithUpdates));
                }
            }
        }
    }
}
