using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Library
{
    public class Arrays
    {
        public static void SpiralArray(int[,] input)
        {
            int rowCount = input.GetLength(0);
            int columnCount = input.GetLength(1);
            int upLimit, rightLimit, downLimit, leftLimit;

            for (int i = 0; i < columnCount; i++)
            {
                Console.WriteLine(input[i, 0]);
            }

            for (int i = 1; i < rowCount; i++)
            {

            }


        }
    }
}
