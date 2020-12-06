using System;
using System.IO;

namespace Advent_of_Code.Day_1
{
    public class Part2
    {
        static void Main(string[] args)
        {
            //Get the input
            string[] txt = File.ReadAllLines("input.txt");
            int[] input = Array.ConvertAll(txt, s => int.Parse(s));

            int outerloop = 0;
            int middleloop = 0;

            while (outerloop < input.Length)
            {
                while (middleloop < input.Length)
                {
                    if (outerloop != middleloop)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (outerloop != i && middleloop != i)
                            {
                                if ((input[outerloop] + input[middleloop] + input[i]) == 2020)
                                {
                                    Console.WriteLine(
                                        $"{input[outerloop]} * {input[middleloop]} * {input[i]} = {input[outerloop] * input[middleloop] * input[i]}");
                                    return;
                                }

                                //else
                                //{
                                //    Console.WriteLine($"{input[outerloop]} + {input[middleloop]} + {input[i]} = {input[outerloop] + input[middleloop] + input[i]}");
                                //}
                            }
                        }
                    }

                    middleloop++;
                }

                middleloop = 0;
                outerloop++;

            }
        }
    }
}
