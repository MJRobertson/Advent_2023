using System.Diagnostics;
using System;
using System.IO;
using System.Reflection;
using adventofcode.source;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string folder = Directory.GetParent(workingDirectory).FullName + "\\Advent_2023\\";
            string path = Path.Combine(folder, @"data/day1.txt");
            string[] lines = TextParser.ReadLines(path);
            string answer = "";
            //answer = Day1.Part1(lines);
            answer = Day1.Part2(lines);
            Console.WriteLine(answer);
            //Console.WriteLine(Day6Part2Answer);
        }
    }
}
