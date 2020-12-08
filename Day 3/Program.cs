﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int trees = SolvePartOne(input);
            Console.WriteLine($"Part one: there are {trees} trees");

            trees = SolvePartTwo(input);
            Console.WriteLine($"Part two: there are {trees} trees");
        }

        private static int SolvePartOne(string[] input)
        {
            return Ski(input, 3, 1);
        }

        private static int SolvePartTwo(string[] input)
        {
            List<int> trees = new List<int>();
            List<Slope> slopes = new List<Slope>()
            {
                new Slope(){ X=1, Y=1},
                new Slope(){ X=3, Y=1},
                new Slope(){ X=5, Y=1},
                new Slope(){ X=7, Y=1},
                new Slope(){ X=1, Y=2}
            };

            foreach (Slope slope in slopes)
            {
                trees.Add(Ski(input, slope.X, slope.Y));
            }

            //TIL aggregate function in LINQ
            return trees.Aggregate(1, (x, y) => x * y);
        }

        private static int Ski(string[] input, int xGrow, int yGrow)
        {
            int trees = 0;
            int widthOfMap = input[0].Length;
            int heightOfMap = input.Length;
            int y = 0;
            int x = 0;
            while (y != heightOfMap - 1)
            {
                y += yGrow;
                x += xGrow;
                if (x >= widthOfMap)
                {
                    x = x - widthOfMap;
                }

                char mapField = input[y][x];
                if (mapField.ToString() == "#")
                {
                    trees++;
                }
            }

            return trees;
        }
    }

    class Slope
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
