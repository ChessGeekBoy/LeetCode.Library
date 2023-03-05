using System;
using System.Collections.Generic;

namespace LeetCode.Library
{
    public static class FrequencyProblem
    {
        
        public static string GetNthFrequencyString(in int count, in string seed)
        {
            string returnValue = seed;

            for (int counter = 0; counter < count; counter++)
            {
                returnValue = GetNext(returnValue);
            }

            return returnValue;
        }

        private static string GetNext(in string seed)
        {
            string returnValue = string.Empty;
            char previousChar = seed[0];
            int count = 1;

            for (int index = 1; index < seed.Length; index++)
            {
                char currentChar = seed[index];
                
                if (previousChar != currentChar)
                {
                    returnValue += previousChar + count;
                    // Change incrementing number
                    previousChar = currentChar;
                    count = 1;
                } else
                {
                    count++;
                }

            }
            returnValue += previousChar + count;

            return returnValue;
        }
    }

}