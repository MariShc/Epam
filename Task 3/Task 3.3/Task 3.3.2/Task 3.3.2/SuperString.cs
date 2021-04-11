using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3._2
{
    public static class SuperString
    {
        public static string DefineLanguage(this string str)
        {
            int rusCount = 0;
            int engCount = 0;
            int numCount = 0;
            int mixCount = 0;
            string language = "";
            foreach (char c in str)
            {
                if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                    rusCount++;
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    engCount++;
                else if (c >= '0' && c <= '9')
                    numCount++;
                else
                    mixCount++;
            }
            if (str.Length == rusCount) language = "Russian";
            else if (str.Length == engCount) language = "English";
            else if (str.Length == numCount) language = "Number";
            else language = "Mixed";
            return language;
        }
    }
}
