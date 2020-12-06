
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Advent_of_Code.Day_2
{
    public class Part1
    {
        static void Main(string[] args)
        {
            string[] txt = File.ReadAllLines("input.txt");
            int valid = 0;

            foreach (var info in txt)
            {
                var split = info.Split(' ');
                var rule = split[0];
                var letter = Char.Parse(split[1].Remove(1));
                var hex = split[2];
                int min = int.Parse(rule.Split('-')[0]);
                int max = int.Parse(rule.Split('-')[1]);

                if (hex.Count(x => x == letter) >= min && hex.Count(x => x == letter) <= max)
                {
                    valid++;
                }
            }

            Console.WriteLine($"There are {valid} valid passwords");
        }
    }
}
