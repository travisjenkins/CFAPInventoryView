using CFAPInventoryView.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Reflection;
using System.Text.Json;

namespace CFAPInventoryView
{
    public static class HelperMethods
    {
        public const string AdministratorRole = "Administrator";
        public const string ManagerRole = "Manager";
        public const string MemberRole = "Member";
        
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

        public static async Task PrepareErrorsForTransfer(ModelStateDictionary modelState, ITempDataDictionary tempData)
        {
#pragma warning disable CS8602 // Defreference of a possibly null reference
            var dictionaryOfErrors = modelState.Where(s => s.Value.Errors.Any()).ToDictionary(m => m.Key, m => m.Value.Errors.Select(s => s.ErrorMessage).FirstOrDefault(s => s is not null));
#pragma warning restore CS8602 // Defreference of a possibly null reference

            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, dictionaryOfErrors);
            stream.Position = 0;

            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();

            tempData["ModelState"] = json;
        }

        public static void RetrieveTransferredErrors(ModelStateDictionary modelState, ITempDataDictionary tempData)
        {
#pragma warning disable CS8602 // Defreference of a possibly null reference
            var modelStateString = tempData["ModelState"].ToString();
#pragma warning restore CS8602 // Defreference of a possibly null reference
            if (!string.IsNullOrEmpty(modelStateString))
            {
                var dictionaryOfErrors = JsonSerializer.Deserialize<Dictionary<string, string?>>(modelStateString);
                if (dictionaryOfErrors is not null)
                {
                    foreach (var item in dictionaryOfErrors)
                    {
                        modelState.AddModelError(item.Key, item.Value ?? "");
                    }
                }
            }
        }

        private static readonly List<string> _USStateNames = new()
        {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "NewHampshire",
            "NewJersey",
            "NewMexico",
            "NewYork",
            "NorthCarolina",
            "NorthDakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "RhodeIsland",
            "SouthCarolina",
            "SouthDakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "WestVirginia",
            "Wisconsin",
            "Wyoming"
        };

        private static readonly List<string> _USStateAbbreviation = new()
        {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"
        };

        public static List<string> GetUSStatesList()
        {
            var usStateList = new List<string>();
            for (int i = 0; i < _USStateNames.Count; i++)
            {
                usStateList.Add($"{_USStateNames[i].SplitCamelAndPascalCase()} - {_USStateAbbreviation[i]}");
            }
            return usStateList;
        }

        public static string JustTheStateName(string longName)
        {
            if (string.IsNullOrEmpty(longName)) return string.Empty;
            if (!longName.Contains(' ')) return string.Empty;
            return longName.Split(' ')[0];
        }
    }
}
