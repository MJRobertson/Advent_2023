using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace adventofcode.source
{
    public static class Day1
    {
        //find out how many times it increases
        public static string Part1(string[] data)
        {
            long currentTotal = 0;
            string regexFirstNumber = @"\d+";
            string regexLastNumber = @"(\d+)(?!.*\d)";

            foreach (var str in data)
            {
                var first = Regex.Match(str, regexFirstNumber).Value.ToString()[0];
                var last = Regex.Match(str, regexLastNumber).Value.ToString();
                var lastSingle = last[last.Length - 1];

                Console.WriteLine(str + "  =   " + first + "  -  " + lastSingle);
                string combined = $"{first}{lastSingle}";
                currentTotal += int.Parse(combined);
            }

            return currentTotal.ToString();
        }

        //sum for three measurements using letters to match
        public static string Part2(string[] data)
        {
            return "";
        }

    }
}
