using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringUtilities;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//String erzeugen
            int number = 69;
            double price = 4.20;

            string usedToString = number.ToString();
            string usedStringFormat = string.Format("{0}", number);
            string usedInterpolatedString = $"{number}";
            //Ausgabe direkt
            Console.WriteLine("{0}", number);

            //mit mehreren Werten
            string description = "Pizza";
            // 42 quantity Pizza 4.20
            string simplyConcatentad = number.ToString() + " quantity " +
                description + ": " + price.ToString();
            usedStringFormat = string.Format("{0} quantity {1}: {2}", number, description, price);
            string usedStringFormat_ver2 = string.Format("{2} quantity {0}: {1}",description, price, number);
            usedInterpolatedString = $"{number} quantity {description}: {price}";

            //mit Formatspezifikation
            usedStringFormat = string.Format("{0:D4} quantity {1} : {2:C}", number, description, price);
            usedInterpolatedString = $"{number:D4} quantity {description}: {price:C}";

            //mit Feldlängen
            usedStringFormat = string.Format("{0,10} quantity {1} : {2,-10}", number, description, price);
            usedInterpolatedString = $"{number,-10} quantity {description}: {price,10}";

            //mit Formatspezifikation und Feldlänge
            usedStringFormat = string.Format("{0,10:D4} quantity {1} : {2,-10:C}", number, description, price);
            usedInterpolatedString = $"{number,-10:D4} quantity {description}: {price,10:C}";
            //andere Formatspezifikation
            usedInterpolatedString = $"{number,-10:D4} quantity {description}: {price,10}";

            //Informationen bekommen
            string simpleSentence = "Ein ganz einfacher Satz.";
            string wihUmlauts = "Alle Umlaute: Ää, Öö, Üü, scharfes S ß";
            string numbers = "1234567891011121314151617181920";
            string oddWithespace = "        Satz mit Leerraum           ";
            string withespaceOnly = "    " + "\t" + "\n";
            CultureInfo currentCI = CultureInfo.CurrentCulture;             //Ermöglicht die nicht case-sensitive bedienung
            CultureInfo en_US_CI = new CultureInfo("en-US");


            int lengthOfSentence = simpleSentence.Length;
            char charIn2ndPlace = simpleSentence[1];
            bool has_z = simpleSentence.Contains("z");
            int positionFirst_a = simpleSentence.IndexOf('a');
            //int positionFirst_a = simpleSentence.IndexOf("a");        String geht auch
            int positionSecond_a = simpleSentence.IndexOf('a', positionFirst_a + 1);
            int containsNo_x = simpleSentence.IndexOf('x');
            int positionLast_a = simpleSentence.LastIndexOf('a');

            bool startWith_Ein = simpleSentence.StartsWith("Ein");
            bool startWith_ein = simpleSentence.StartsWith("ein");
            bool startWith_Ein_or_ein = simpleSentence.StartsWith("ein",
                ignoreCase: true,
                culture: CultureInfo.CurrentCulture);

            //Ausgabe der Code-nummern aller Zeichen in WhitespaceOnly
            for (int i = 0; i < withespaceOnly.Length; i++)
            {
                char currenChar = withespaceOnly[i];
                int currentCode = withespaceOnly[i];
                Console.WriteLine($"{currenChar} : {currentCode}");
            }

            bool containsWhitespaceOnly = string.IsNullOrWhiteSpace(withespaceOnly);

            //neue strings aus bestehenden erzeugen
            string twoSentences = string.Concat(simpleSentence, oddWithespace);

            string withoutFirst7Chars = numbers.Substring(7);
            string onlyFirst7Chars = numbers.Substring(0, 7);

            string variation1 = simpleSentence.Replace('a', 'A');
            string variation2 = simpleSentence.Replace("ganz", "ziemlich");

            string noSpaceAtEnds = oddWithespace.Trim();
            string noSpaceAtFront = oddWithespace.TrimStart();
            string noSpaceAtEnd = oddWithespace.TrimEnd();

            string paddedLeft = noSpaceAtEnds.PadLeft(30, '*');
            string paddedRight = noSpaceAtEnds.PadRight(20);

            string upperCase = simpleSentence.ToUpper();
            string lowerCase = simpleSentence.ToLower();

            string[] words = simpleSentence.Split(' ');
            string[] wordsOrNothing = oddWithespace.Split(' ');
            string[] justWords = oddWithespace.Split(
                separator: new char[] { ' ' },
                options: StringSplitOptions.RemoveEmptyEntries);
            string[] withSpaceOnlySplitOnSpace = withespaceOnly.Split(' ');
            string joinedAgain = string.Join("*", words);
            char[] charsOfSimpleSentence = simpleSentence.ToCharArray();

            //strings erzeugen
            string dateipfad = "C:\\Windows\\System32";
            dateipfad = @"C:\Windows\System32"; //verbatim String

            char[] klassenName = { '2', 'Y', 'K', 'W', 'I', 'B', 'F' };
            string klasse = new string(klassenName);
            string sixtyNice = new string('*', 69);*/
            string test = "eaedserserresrresfdfefsfsefwef";
            char symbol = 'e';
            string someText = "   This is a text";
            
            int amountOfE = countAChar(test, symbol);
            int amountOfE2 = StringUtilities.stringUtility.countACharWithShorterForeach(test, symbol);
            string firstWord = StringUtilities.stringUtility.GetFirstWordFromString(someText);
            bool isPalidrom = StringUtilities.stringUtility.IsPalindrom("AA");
            Console.ReadLine();
        }

        /*Methode zum zählen von 'e' in einem übergebenen string*/
        static int countAChar(string stringToCount, char symbol)
        {
            int amount = 0;

            foreach (char character in stringToCount)
            {
                if (character == symbol)
                {
                    amount++;
                }
            }

            return amount;
        }
        /*Fehleranalyse
         * 
         * 
         * */


    }
}
