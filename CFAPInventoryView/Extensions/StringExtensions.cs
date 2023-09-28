using System.Text.RegularExpressions;

namespace CFAPInventoryView.Extensions
{
    public static partial class StringExtensions
    {

        public static string SplitCamelAndPascalCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
            return FirstWord().Replace(SecondWord().Replace(str, "$1 $2"), "$1 $2");
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
                if (i != arrOfStrings.Length - 1)
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

        [GeneratedRegex("(\\p{Ll})(\\P{Ll})")]
        private static partial Regex FirstWord();

        [GeneratedRegex("(\\P{Ll})(\\P{Ll}\\p{Ll})")]
        private static partial Regex SecondWord();
    }
}
