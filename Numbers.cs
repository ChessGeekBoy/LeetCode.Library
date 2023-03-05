using System;

namespace LeetCode.Library
{
    public class Numbers
    {
        public static bool CheckIfPalindrome(int input)
        {
            return input == EfficientReverseNumber(input);
        }

        public int? ReverseNumber(int input)
        {
            int modAmount = 1;
            int? result = null;

            do
            {
                modAmount *= 10;

                if (result == null)
                {
                    result = input % modAmount;
                }
                else
                {
                    result *= 10;
                    result += (result % modAmount) - ((result / 10) % modAmount);
                }

            } while (modAmount < input);

            return result;
        }

        public bool IsPalindrome(int input)
        {
            return ReverseNumber(input) == input;
        }

        public static int EfficientReverseNumber(int input)
        {
            int result = 0;
            
            // input 123 |
            while (input != 0)
            {
                result *= 10; // 0 | 30 | 320
                result += input % 10; // 3 | 32 | 321
                input /= 10; // 12 | 1 | 0
            }

            return result;
        }

        public static int TitleToNumber(string columnTitle)
        {
            // Variable assignment
            int returnValue = 0;
            int placeValue = 1;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            // Processing
            for (int index = columnTitle.Length - 1; index > -1; index--)
            {
                returnValue += (alphabet.IndexOf(columnTitle[index].ToString().ToLowerInvariant()) + 1) * placeValue;
                placeValue *= alphabet.Length;
            }

            // Returning result(s)
            return returnValue;
        }

        public static string BinaryAddition(string a, string b)
        {
            string result = string.Empty;
            bool carry = false;

            // First, check which string is longer, so that the loop doesn't stop prematurely.
            // Never mind, there's no need for that previous bit.
            // Next, loop through the strings and perform addition. If there is a carry, set the "carry" variable to "true".


            // Finally, return the result.
            return result;
        }
    }
}