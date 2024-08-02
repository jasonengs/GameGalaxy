using System.Globalization;
using System.Text;

namespace GameGalaxy.Models
{
    public static class StringExtension
    {
        public static string NormalizeString(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            input = input.Normalize(NormalizationForm.FormD);
            var chars = input.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);
        }
    }
}
