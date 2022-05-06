using System.Linq;

namespace Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsUseful(this string value)
        {
            return !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value);
        }
        
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static string SafeSubstring(this string text, int start, int length)
        {
            if (text == null)
            {
                return null;
            }

            return text.Length <= start ? ""
                : text.Length - start <= length ? text.Substring(start)
                : text.Substring(start, length);
        }

        public static bool SafeContains(this string text, string searchTerm)
        {
            return !text.IsNullOrEmpty() && text.Contains(searchTerm);
        }

        public static bool SafeStartsWith(this string text, string searchTerm)
        {
            return !text.IsNullOrEmpty() && text.StartsWith(searchTerm);
        }

        public static bool ContainsTurkishChar(this string target)
        {
            var trCharList = "ğüşıöçĞÜŞİÖÇ".ToList();
            return target.Any(trCharList.Contains);
        }

    }
}