using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Models
{
    public class RomanNumeralConvertor
    {
        public RomanNumeralConvertor() { }
       
        public static int ConvertRomanNumeral(string RomanNum)
        {
            int count = 0;
            Dictionary<char, int> RomanNumeralDictionary = new(){
                {'I', 1},
                {'V', 5},
                {'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            
            for (int i = 0; i < RomanNum.Length; i++)
            {
                char currentRomanchar = RomanNum[i];
                RomanNumeralDictionary.TryGetValue(currentRomanchar, out int num);
                if (i + 1 < RomanNum.Length && RomanNumeralDictionary[RomanNum[i + 1]] > RomanNumeralDictionary[currentRomanchar])
                    count -= num;
                else
                    count += num;
            }
            
            return count;
           
        }

    }
}
