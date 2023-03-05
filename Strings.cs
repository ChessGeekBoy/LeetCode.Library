using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Library
{
    public static class Strings
    {
        public static string ConvertToTitle(int columnNumber)
        {
            string title = string.Empty;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int placeValue = 1;

            do
            {

            } while (placeValue < columnNumber);

            return title;
        }

        public static bool IsValidParentheses(string input)
        { 
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '[' },
                {'}', '{' }
            };

            for (int index = 0; index < input.Length; index++)
            {
                if (stack.Count == 0 && keyValuePairs.ContainsKey(input[index]))
                {
                    return false;
                }
                else if (keyValuePairs.ContainsKey(input[index]))
                {
                    if (stack.Pop() != keyValuePairs[input[index]])
                    {
                        return false;
                    }
                }
                else if (keyValuePairs.ContainsValue(input[index]))
                {
                    stack.Push(input[index]);
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
