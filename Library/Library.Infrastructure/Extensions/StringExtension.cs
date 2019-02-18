using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Infrastructure.Extensions
{
    public static class StringExtension
    {
        public static string LeaveOnlyLetters(this string text)
        {
            var lettersRegex = new Regex("[^a-zA-Z ]");
            text = lettersRegex.Replace(text, "");

            text = text.RemoveWhitespace();

            return text;
        }

        public static string RemoveWhitespace(this string text)
        {
            text = text.Trim();

            var whitespaceRegex = new Regex(@"\s{2,}");

            while (whitespaceRegex.IsMatch(text))
                text = whitespaceRegex.Replace(text, " ");


            return text;
        }

        public static string FirstLettersToUpper(this string text, bool isOnlyLetters)
        {
            if (isOnlyLetters)
            {
                text = text.LeaveOnlyLetters();
                text = text.ToLower();

                if (text == "")
                    return "Error";
            }

            text = text.First().ToString().ToUpper() + text.Substring(1);

            var whitespaceRegex = new Regex(@"\s");

            var wordArray = whitespaceRegex.Split(text);

            var textAfterCapitalisation = "";

            foreach (var word in wordArray)
                textAfterCapitalisation += word.First().ToString().ToUpper() + word.Substring(1) + ' ';

            return textAfterCapitalisation.Trim();
        }

        public static string OnlyNumbers(this string text)
        {
            text = text.Trim();

            var whitespaceRegex = new Regex(@"\s");

            while (whitespaceRegex.IsMatch(text))
                text = whitespaceRegex.Replace(text, "");

            var numbersRegex = new Regex("[^0-9 ]");

            while (numbersRegex.IsMatch(text))
                text = numbersRegex.Replace(text, "");

            return text;
        }

        public static bool GradeFormat(this string text)
        {
            var firstLetterRegex=new Regex(@"^\d");
            var secondDotRegex=new Regex(@"^.[.]");
            var lastLetterRegex=new Regex(@"^..[a-zA-Z]$");

            if (!firstLetterRegex.IsMatch(text))
                return false;
            if (!secondDotRegex.IsMatch(text))
                return false;
            if (!lastLetterRegex.IsMatch(text))
                return false;

            return true;
        }
    }
}
