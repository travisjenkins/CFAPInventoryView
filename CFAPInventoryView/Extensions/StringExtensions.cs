using System.Text.RegularExpressions;

namespace CFAPInventoryView.Extensions
{
    public static class StringExtensions
    {
        public static string SplitCamelAndPascalCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
#pragma warning disable SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.
            return Regex.Replace(
                    Regex.Replace(
                            str,
                            @"(\P{Ll})(\P{Ll}\p{Ll})",
                            "$1 $2"
                        ),
                        @"(\p{Ll})(\P{Ll})",
                        "$1 $2"
                );
#pragma warning restore SYSLIB1045 // Convert to 'GeneratedRegexAttribute'.
        }

        public static string Capitalize(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
            return str[..1].ToUpperInvariant() + str[1..];
        }

        public static string TitleCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
            if (!str.Contains(' ')) return str;
            string[] arrOfStrings = str.Split(" ");
            string titleCaseString = string.Empty;
            for (int i = 0; i < arrOfStrings.Length; i++)
            {
                if (i != (arrOfStrings.Length - 1))
                {
                    titleCaseString += arrOfStrings[i][..1].ToUpperInvariant() + arrOfStrings[i][1..] + " ";
                }
                else
                {
                    titleCaseString += arrOfStrings[i][..1].ToUpperInvariant() + arrOfStrings[i][1..];
                }
            }
            if (!string.IsNullOrEmpty(titleCaseString)) return titleCaseString;
            return str;
        }
    }
}
