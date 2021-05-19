using System;
using System.Text.RegularExpressions;

namespace Task_3_3_2
{
    public static class StringExtensions
    {
        public static StringLanguage DefineStringLanguage(this string text)
        {   
            if(Regex.IsMatch(text, "[^A-Za-zА-ЯЁа-яё0-9]"))
            {
                return StringLanguage.Mixed;
            }
            
            if(Regex.IsMatch(text, "[A-Za-z]") && !Regex.IsMatch(text, "[А-ЯЁа-яё0-9]"))
            {
                return StringLanguage.English;
            }
            else if (Regex.IsMatch(text, "[А-ЯЁа-яё]") && !Regex.IsMatch(text, "[A-Za-z0-9]"))
            {
                return StringLanguage.Russian;
            }
            else if (Regex.IsMatch(text, "[0-9]") && !Regex.IsMatch(text, "[A-Za-zА-ЯЁа-яё]"))
            {
                return StringLanguage.Number;
            }

            return StringLanguage.Mixed;
        }
        public enum StringLanguage
        {
            Russian = 1,
            English = 2,
            Number = 3,
            Mixed = 4
        }
    }
}
