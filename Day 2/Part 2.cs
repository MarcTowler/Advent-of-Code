
using System;
using System.IO;
using System.Linq;

namespace Advent_of_Code.Day_2
{
    public class Part_2
    {
        static void Main(string[] args)
        {
            string[] txt = File.ReadAllLines("input.txt");
            int valid = 0;
            foreach (string dbRow in txt)
            {
                string[] sp1 = dbRow.Split(":");
                string[] sp2 = sp1[0].Split(" ");
                string[] sp3 = sp2[0].Split("-");

                string code = sp2[1].Trim();
                string password = sp1[1].Trim();
                int min = Int32.Parse(sp3[0].Trim());
                int max = Int32.Parse(sp3[1].Trim());

                string first = password[min - 1].ToString();
                string secound = password[max - 1].ToString();

                // TIL  XOR and != achieve the same result when comparing 2 booleans
                if ((first == code) != (secound == code))
                {
                    valid++;
                }
            }

            Console.WriteLine($"There are {valid} valid passwords");
        }
    }
}
