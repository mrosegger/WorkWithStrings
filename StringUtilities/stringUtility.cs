using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilities
{
    public class stringUtility
    {
        public static int countACharWithShorterForeach(string stringToCount, char symbol)
        {
            int amount = 0;

            int positinOfNextE = stringToCount.IndexOf(symbol);
            while (positinOfNextE >= 0)
            {
                amount++;
                positinOfNextE = stringToCount.IndexOf(symbol, positinOfNextE);
            }

            return amount;
        }

        public static string GetFirstWordFromString(string text)
        {
            if (text == null)
            {
                return null;
            }

            string firstWord;
            text = text.TrimStart();
            if (text.Contains(' '))
            {
                int lengthOfFirstWord = text.IndexOf(' ');
                firstWord = text.Substring(0, lengthOfFirstWord);
            }
            else
            {
                firstWord = text;
            }

            return firstWord;
        }

        /// <summary>
        /// Methode die bestimmt, ob ein übergebener Text ein Palindrom ist
        /// </summary>
        /// <param name="text"></param>
        /// <returns>true, wenn Palindrom</returns>
        /// <remarks>
        /// - Was machen wir mit Leerzeichen? Sind zeichen wie alle anderen
        /// - Case sensitive
        /// - "", null: false
        /// - 1 Zeichen: true
        /// - muss Länge gerade sein? nein
        /// ## testcases
        /// - "", null: false
        /// - Z: true
        /// - ZZ: true
        /// - AZ: false
        /// - Zz: false
        /// - AZA: true
        /// - AAZ: false
        /// - AAA: true
        /// - reliefplfeiler: true
        /// -  neuer reuen: false
        /// -  neuer reuen : true
        /// </remarks>
        public static bool IsPalindrom(string text)
        {           
            if (text.Length%2 == 0)
            {
                string firsthalf = text.Substring(0, text.Length / 2);
                string secondHalf = text.Substring(text.Length / 2);
                secondHalf = secondHalf.
            }
            else
            {

            }
            return false;
        }
    }
}
