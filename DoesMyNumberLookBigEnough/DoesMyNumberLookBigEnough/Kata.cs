using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoesMyNumberLookBigEnough
{
    public static class Kata
    {
        public static bool Narcissistic(int value)
        {
            string numberString = value.ToString();
            int numberLength = numberString.Length;     
           int[] numbersSeparated = new int[numberLength];

            for(int i = 0; i<numberLength; i++){
                numbersSeparated[i] = (int)numberString[i] - (int)'0';
            }
        
            double sum = 0;
            for (int i = 0; i<numberLength; i++){
                   sum += Math.Pow(numbersSeparated[i], numberLength);
            }            
            return sum == value;
        }
    }
}
