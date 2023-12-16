using System.Diagnostics;
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
            long currentTotal = 0;
            string regexFirstNumber = @"\d+";
            string regexLastNumber = @"(\d+)(?!.*\d)";

            Dictionary<string, string> wordsToNumbers = new Dictionary<string, string>{
                {"one","1"},
                {"two", "2"},
                {"three", "3"},
                {"four", "4"},
                {"five", "5"},
                {"six", "6"},
                {"seven", "7"},
                {"eight", "8"},
                {"nine", "9"}
            };

            foreach (var str in data)
            {
                string currentString = "";

                foreach (var c in str)
                {
                    currentString += c;
                    foreach (var n in wordsToNumbers)
                    {
                        if (currentString.Contains(n.Key))
                        {
                            //Console.WriteLine($"{currentString} found key {n.Key} replacing with {n.Value}");
                            currentString = currentString.Replace(n.Key, n.Value);
                            break;
                        }
                    }
                }

                var first = Regex.Match(currentString, regexFirstNumber).Value.ToString()[0];

                currentString = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    currentString = str[i] + currentString;
                    foreach (var n in wordsToNumbers)
                    {
                        if (currentString.Contains(n.Key))
                        {
                            //Console.WriteLine($"{currentString} found key {n.Key} replacing with {n.Value}");
                            currentString = currentString.Replace(n.Key, n.Value);
                            break;
                        }
                    }
                }

                var last = Regex.Match(currentString, regexLastNumber).Value.ToString();
                var lastSingle = last[last.Length - 1];

                Console.WriteLine(currentString + "  =   " + first + "  -  " + lastSingle);
                string combined = $"{first}{lastSingle}";
                currentTotal += int.Parse(combined);
            }

            return currentTotal.ToString();
        }
    }
}
