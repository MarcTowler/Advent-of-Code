using System;
using System.IO;

namespace Advent_of_Code.Day_1
{
    class Part1
    {
        static void Main(string[] args)
        {
            //Get the input
            string[] txt = File.ReadAllLines("input.txt");
            int[] input = Array.ConvertAll(txt, s => int.Parse(s));

            int outerloop = 0;

            while (outerloop < input.Length)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (outerloop != i)
                    {
                        if ((input[outerloop] + input[i]) == 2020)
                        {
                            Console.WriteLine($"{input[outerloop]} * {input[i]} = {input[outerloop] * input[i]}");
                            return;
                        }
                        //else
                        //{
                        //    Console.WriteLine($"{input[outerloop]} * {input[i]} = {input[outerloop] * input[i]}");
                        //}
                    }
                }

                outerloop++;

            }
        }
    }
}
