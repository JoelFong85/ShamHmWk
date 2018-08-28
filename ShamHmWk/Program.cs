using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShamHmWk
{
    class Program
    {

        static void Main(string[] args)
        {
            // must start with letter or _
            // can't be C# keyword
            // no whitespace
            // <511 characters

            Console.WriteLine("Please enter your identifier");
            string inputPhrase = Convert.ToString(Console.ReadLine());

            //if anything is false, we want to break & print error
            if (CheckIfFirstCharIsLetterOrUnderScore(inputPhrase) == false || CheckIfInputIsNotReserveWord(inputPhrase) == false || CheckIfNoWhiteSpace(inputPhrase) == false || CheckIfLessThan511Char(inputPhrase) == false)
            {
                PrintNotValid();
            }

            else
                Console.WriteLine("The word entered is a valid identifier");

        }

        public static void PrintNotValid()
        {
            Console.WriteLine("The word entered is not a valid identifier");
        }

        public static bool CheckIfFirstCharIsLetterOrUnderScore(string inputPhrase)
        {
            //return false if letter or _ exists

            bool isAlphabet = Regex.IsMatch(inputPhrase.Substring(0, 1), "[a-z]", RegexOptions.IgnoreCase);

            if (inputPhrase.Substring(0, 1) == "_" || isAlphabet)
            {
                return true;
            }
            return false;
        }

        public static bool CheckIfInputIsNotReserveWord(string inputPhrase)
        {
            //return false if contains reserveword

            string[] reserveWords = new string[] { "abstract", "as", "base", "bool", "while" }; //can get a full list of reserve words, shortening list for simplicity.

            foreach (string rw in reserveWords)
            {
                if (inputPhrase == rw)
                {
                    return false;
                }
            }

            return true;
        }


        public static bool CheckIfNoWhiteSpace(string inputPhrase)
        {
            if (inputPhrase.Contains(" "))
            {
                return false;
            }
            else
                return true;
        }

        public static bool CheckIfLessThan511Char(string inputPhrase)
        {
            if (inputPhrase.Length > 511)
                return false;
            else
                return true;
        }

    }

}
