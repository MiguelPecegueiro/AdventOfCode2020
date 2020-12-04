﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    class Day3
    {
        public static void Part1()
        {
            int tree = 0;
            int square = 0;
            string[] input = new string[] { ".##.............##......#.....#", ".#.#................#..........", "...#..#.##..#.#......#.#.#.#..#", "..#......#........#..#..#.#.#..", ".......#....#..#..#.......#....", "..#..#..##.#...#........#.###..", "..#...#..#.....#.##....#.......", "....#..###.#......#.##..#...##.", "..#..........#.##.#...#........", "#...#............##....#..##...", ".......##....#.....##..#.#..#.#", "..#..#..#...#....#....#....#...", ".#...#.##........#####........#", "..#..#......#.....##...#.......", "....#......##....#.#....#.#..##", "#.#.##....##..#.........#.###..", "##..###..#..#.......###.......#", "...#.#......#.........#....#...", ".....#..........#.....##..#.#..", "....##......#.#..#....#.#......", "..#.....#..##.......##......#..", ".........##.##.#..##...........", "....#...#.....#....#.#.###....#", ".##.#..#...##..#.......#......#", "##..#..#..####..#.#..#...#.....", "..###..#..#..#.###..#....#.##..", "......#...###.#.#.....#........", ".....#...#.#...#.......#.....#.", "#........#..##...........#..#..", ".#.##.##...#.....#.#....#..#...", "..##.##....#.....#....#....##..", "#.........##...##..#.....#..#..", "........#.####....#...##.....#.", ".#.#...#..#..#.#......##.....#.", "..#..........##..#.#.#....#...#", "#.......#...#...#.....#.##.#...", "..#.....#..#.....####.#..#.#.##", "...#.#..#...#.....#...#.#.#.#.#", ".#..##....##.....#..#....###...", "....#......##.#.#.....#......#.", "..#.#...#......#.....##.......#", "..#...###...#..#.#...#..#.....#", "#..............#.....#....##..#", ".#...#.......#.............#...", "..###....#.##........#.#.......", "#.##.......#..#............###.", "#...#..##.#.#............######", "..##..#....#.#.###...#..##.##..", ".#...#.###.#....#...#....#...#.", "#...#.......#...........#...##.", "##.#......#####.............#..", "....#..#......##..#..........#.", "#.....#.....#.#.......#...#...#", "....#...#.#..##........#.#..##.", "..##.....##............#.#.###.", "#.........#........#..###......", "............#..................", ".#.###...####...#.#..#......#..", "...##.###.#....##.#..####..#.##", "..#####.#.##...#.#...##.##....#", "........##...#...#....##.....##", "#...........###...#.#...##.#...", "##......#...#.......###........", "..#..#.##.#..###....#..#.###.#.", "...#.#.#...#....#.##..#...#....", "........#.##...##.#.....##...##", ".#..........##..#..#..#.#...#..", "#.#...#.##.#....#.##..#........", ".#.#.#....##..##.####.....###..", "..#....##....#..#..#..##.......", "..##...#.......#...##.#....#...", "...####.#.#...........#.#...#..", "....####.....#.#.....#....##.##", "..#.....#.#.............##....#", "#.#....#####.##..####.#...#.#..", "#.#....#.##.#.#.##..#.#...#....", "......#.......#.......#.....#..", "..#.....#....###.###..#..#..#..", "#..#....##.###...##.....#......", "..#..#...#..#.##..........#....", "...#.#.#......#....#.##..#..##.", "....##.#....#..#...##....###...", "##.#.###.....#..#.#.#..#.....##", "##..#.#........#...#..#.#......", "....#.#.......##.#...........#.", ".......##...#...#...#.....#....", ".....#....#..#..###.#...#......", "............#.#..#......#.#....", "...##..#.##....##..##.#......#.", "#.#.#......#.#.....#.#.#..#.#.#", "...###..........#..#..#.##.....", "......#......#......###..##....", "#...##...#....#....#..#...#.#..", ".......#..#......##.......#....", "...#..#..#.....#.....#......##.", "..#....###..........##..#...#..", "..........#..#.#...#......#..#.", "#...#....#.##.........#.#.#...#", ".#.#.#...#.#...#.#..#..#....#.#", "#.##....#..#.........#.##.##..#", "..#.#..##.#....#.###.#...#....#", ".#.......#...#.#.........#....#", ".......#...#..........#.#..#...", "...#.....##..#....#...###...#.#", "#....##.##..........#.......#..", ".##..##......#...#....#.##....#", "....#.....##...##.#..#.........", "...#.#..##.#.#..#.......#....#.", ".#...#.#.#.#..#..#.##.......#..", "..#..##...#.#..#.......#.#####.", ".......#.#...........#....#.#..", ".#.###..........#...#..#...#...", "..#.#............##......##....", "...##..#...###...##....#.#.##..", "....#.##...#..#.#.#...........#", "....#..#....##.....#.##.#.....#", "..##......##.#.........#....#.#", "###...#...#..#.#...#...........", ".####.....#.....#.#....#..#....", ".#....#..#..#..#...##.....###.#", "#....##.#....#.##..#......##..#", ".........#..#.#.....#.#....##.#", ".....#.#...#....#.#...#....#..#", ".#...#.#.....#.#......#.#......", "#....##.......#.............#..", "#..#...#........##..#..#......#", "####..##.#..##..#.........####.", ".#.##..#.#..#.#.#.##...#..#.#.#", ".##.#..#............#......#...", "###....#.##....#..#...#........", ".....#..###..........#..#......", ".##..##.....#..##....#...#.....", "#...##...........#..#...###..#.", "#..##....#...#.##.##....#......", "...#...#..#.#.......##.......##", "....#.....#..#...#.........#.#.", ".#...##.#......#.#..#..#...##..", "...##...##.##...##...#..#......", "#..##.#..#..#............#...#.", "..#.....#.........#........#.#.", "#.#...#...#......#.#......#....", ".##.....##.#.#....#.##...##.#..", ".##..##.#.#....#.##............", ".#.##.....##.#...#...###....#..", ".#..............#.#....###.###.", "....#..#...#.#.#..........#.#.#", ".#.#..#.#.#...###..#...##......", ".#.#.....###......#..........#.", "........#.##...............#.#.", "...#.#.#......#..#..##........#", "..#.##......#.......#..#......#", "...#...#...#...#..#..#........#", "..#....#.....#....#..##........", ".....#..#...##....#......##....", "...##..##..#..........##....#.#", "..#....#..#...#.##..#.....##...", "###...#.#....#........#.......#", "......#...#..#....###.........#", "..###.#...#...#...#.#..###.#...", ".##.#.......#.#..#..#......#.#.", "...##...........#.#..#.#..#....", ".......#.....####.#.....#...#.#", "......##......##.#.#.#...#.#..#", "..###.#####..#....#.#...#..##..", ".....#..#......#........#......", "#..##....#.#.##....#....#......", ".#....#.##.####.##..#..#......#", "#...##...#.#...##.#.##.##...#..", "........#.#........#.#...#..#..", ".#....###..#......#.##.###..#..", ".#..#..#..#..#...#.#.........##", "....#...#..#..............#....", "........#...##.....#.......#...", "..#......#.#..#.#..#.#.#...###.", "....#...####....###....#......#", "#...#.#...................#.##.", "..#.#.###...#....##....##......", "#..##..#.........#....#....####", ".#....###...#.#...#......#...#.", "......#..#.#..#.##...#.#.#..#..", ".#...#.#.....#..##......#..#...", "##.#..##.....##.#.#.......##...", ".##.##.##..#...#.#.##.##.......", ".#.#......#.....#...#.#..#.....", "...#...........#..#.##..##..#..", ".....#...##......#........#.#..", "....#..............##.........#", "..####.#....##..##......##.#.#.", ".#.#..#...#..........#...###..#", "....#.#.##.....###.#..#.##.....", ".......##.#.#..#...#...##.#....", "...#.##.....#....#...#...#.....", "##.#.##..#..#.#.....#.#..#.....", "..#..##........#....###..#..#..", "..#.........##.....#......#...#", "...##..........##......#.#.#...", "#.....#..#..#......#......#....", ".##...#..##....#.......##..#.#.", ".#...##...##......####.##.#....", ".....#.........#.#.####......#.", "...#.....#.#.........##..#.....", "##.#.###.#..#.#..#............#", "...##..#.#....#....#..#........", "..#.###......#...#.#.....#...#.", "....##.##..#.....#...#.#.#....#", ".......#.#..#...........#.#....", ".#.#..##.#.......#.#..#.....###", "...#.#.....#.#..#.##..#...#.#..", "...#......##....#..............", "......#...#....................", "..#........#...##.##.#..#.#.#..", ".#.###.#.##..##..#....##....#..", ".....#..#.#...#.#..#..#.......#", "..........#.##.#..##..####.....", "............#.#......#.........", ".#....#..#......#.....##.......", ".....#........#.....##.#..#.#..", "#..#.##...#.#.....#...#.####...", "......#...#....#.##..##.#...#..", ".#.#.##......##....#.#....#.##.", "#.#.#....#.###....##....##.....", ".##..#...#.##......#..#..#...##", "...#....###....#...........#.#.", "#.#.##.##...##....#....##.#...#", ".#.#######.......#......#......", "#......#...#.#.#.###....#.##..#", "......##..#..##.........##.#.##", "....##...#.#....##.....#.....#.", "..#.#........##........#.#..##.", ".....#..#.##.....#.....#..#.#..", ".#..............#.......#......", ".............#..#..........#...", ".#..#.##....##.#..#...##.......", "...........#..#.......#.#....#.", ".#..#..........##...#.#.#...#..", "......#....#..###....#......#..", ".#...#...##..#..#..##..#..#.#..", "#.#.........#....#..........##.", "...##..#..##...#....##...##.##.", "..#....#.####.........#.....##.", ".....#.#...#.#...#.##.#...##..#", "#...#.....#..#.......#...#..#..", "..#.......#..##.#.....#....#...", ".#.....#..##.#.....#...#.#...#.", ".....#.##..........##....#...#.", "...#....#...#........##...#...#", "....##...#....#..........#.....", "...#....##..#..####..##.#...#.#", "#...###.###..#....##.#.........", ".#.......#......#.........#....", "..#..##..#.........##..........", "#......#.#.##...#...#####......", "......#.....####......#....#...", ".........#..#..#...#....#.#....", "....#........#...##....#.......", "...##.#...#..........#....#....", "........#.......#.##..#..#...#.", "....#..##...........#.....#..#.", "#....#...............#.#....#..", ".#........#....#.#...#.......#.", "#.......##..........#.......#..", "...#....#...##.#..#.......#....", "#..#.##...#.#...#...#...#....#.", "###...#...#....#....#....#...#.", "##......#.#.......#....#..#....", "......#......#....#.#.#..###..#", ".#.#.##.....#..#..........#....", "##...#.#.#..##....#.....#.#....", "#.##...#...#.#...####..#.......", ".....##..#.#.#....#..##..#.#...", "....###.#.........##.....#.....", "......##...........#........#.#", ".#.........##..................", ".........##...#.............#.#", "......##...#...#.........#..##.", "#..#.......#..##.......###.....", "....#.#.....#............##....", ".....#..#......#....#.....##...", "##......##...................#.", "#....#............#.#.###.##...", ".#.....#........#.....#...#....", "......##.......######......##..", ".#....##....#..###....#.......#", "..............##.#..#.......#.#", ".#..#..........#..#.##.........", "......##.#..#......#.#....##.#.", "#.....#.##...#.....#...#..#...#", ".#....#..##.....#.....#.#.#....", "..#......#.##..#.........#.#.#.", ".#..##...#...#.....#..#..#.#..#", "#.#.##.##.................#.#.#", ".#..#.#..##.#.......#.......##.", "#...#...#..##...#...##...#...#.", "....#......#..#...#.....##..#..", "..............##......#...#.#..", "..##..#.......#..#..###.#.#....", ".#..#..#...#.......#...#...##.#", ".#...#.......###..#.##.###.....", "##.#...#......#.....#..#.......", "##....##............#.....#..#.", ".....#...##......##.....#....##", "#...##..#....#..##....###.#...#", ".....#..#.#.....#.##..##....#..", ".#.....#.#........#...#.#......", "......#....#.#........#.#......", ".##..#...............###...##.#", ".......###.#.#......###.....#..", ".......#..##...#....#.##..#.##.", "..#.......##.......#.....#....#", ".#......#....#..##..#.#.#..##..", "###......#...#..#.............#", ".#....#..#.#......##...........", ".#....#.##.....#..#.......#..##", "....#...#...#..#.....#..##..#.#", "#.#.#.......##.#..#.#....#.....", "##.#.......#...#...#.#......##.", "#....#.#...........#######.....", "...#.#.##.#......##..###.......", "..#.#....#..#.................#", "........#..##..#.....#....#.##.", "...#.#..#..#..#..............##", ".##.......###.#......#....#..##", "..##.##.#......#....#..#...#..#" };
            int x = 0;
            int y = 0;
            while (y < input.Length)
            {
                if (x >= input[y].Length)
                {
                    x = x - input[y].Length;
                }
                else { }
                if (input[y].Substring(x, 1) == "#")
                {
                    tree++;
                }
                else
                {
                    square++;
                }

                x = x + 3;
                y++;

            }
            Console.WriteLine(tree + " trees; " + square + " squares");
        }

        public static void Part2()
        {
            decimal value;
            int[] tree = new int[] { 0, 0, 0, 0, 0 };
            int[] square = new int[] { 0, 0, 0, 0, 0 };
            int Countx = 0;
            string[] input = new string[] { ".##.............##......#.....#", ".#.#................#..........", "...#..#.##..#.#......#.#.#.#..#", "..#......#........#..#..#.#.#..", ".......#....#..#..#.......#....", "..#..#..##.#...#........#.###..", "..#...#..#.....#.##....#.......", "....#..###.#......#.##..#...##.", "..#..........#.##.#...#........", "#...#............##....#..##...", ".......##....#.....##..#.#..#.#", "..#..#..#...#....#....#....#...", ".#...#.##........#####........#", "..#..#......#.....##...#.......", "....#......##....#.#....#.#..##", "#.#.##....##..#.........#.###..", "##..###..#..#.......###.......#", "...#.#......#.........#....#...", ".....#..........#.....##..#.#..", "....##......#.#..#....#.#......", "..#.....#..##.......##......#..", ".........##.##.#..##...........", "....#...#.....#....#.#.###....#", ".##.#..#...##..#.......#......#", "##..#..#..####..#.#..#...#.....", "..###..#..#..#.###..#....#.##..", "......#...###.#.#.....#........", ".....#...#.#...#.......#.....#.", "#........#..##...........#..#..", ".#.##.##...#.....#.#....#..#...", "..##.##....#.....#....#....##..", "#.........##...##..#.....#..#..", "........#.####....#...##.....#.", ".#.#...#..#..#.#......##.....#.", "..#..........##..#.#.#....#...#", "#.......#...#...#.....#.##.#...", "..#.....#..#.....####.#..#.#.##", "...#.#..#...#.....#...#.#.#.#.#", ".#..##....##.....#..#....###...", "....#......##.#.#.....#......#.", "..#.#...#......#.....##.......#", "..#...###...#..#.#...#..#.....#", "#..............#.....#....##..#", ".#...#.......#.............#...", "..###....#.##........#.#.......", "#.##.......#..#............###.", "#...#..##.#.#............######", "..##..#....#.#.###...#..##.##..", ".#...#.###.#....#...#....#...#.", "#...#.......#...........#...##.", "##.#......#####.............#..", "....#..#......##..#..........#.", "#.....#.....#.#.......#...#...#", "....#...#.#..##........#.#..##.", "..##.....##............#.#.###.", "#.........#........#..###......", "............#..................", ".#.###...####...#.#..#......#..", "...##.###.#....##.#..####..#.##", "..#####.#.##...#.#...##.##....#", "........##...#...#....##.....##", "#...........###...#.#...##.#...", "##......#...#.......###........", "..#..#.##.#..###....#..#.###.#.", "...#.#.#...#....#.##..#...#....", "........#.##...##.#.....##...##", ".#..........##..#..#..#.#...#..", "#.#...#.##.#....#.##..#........", ".#.#.#....##..##.####.....###..", "..#....##....#..#..#..##.......", "..##...#.......#...##.#....#...", "...####.#.#...........#.#...#..", "....####.....#.#.....#....##.##", "..#.....#.#.............##....#", "#.#....#####.##..####.#...#.#..", "#.#....#.##.#.#.##..#.#...#....", "......#.......#.......#.....#..", "..#.....#....###.###..#..#..#..", "#..#....##.###...##.....#......", "..#..#...#..#.##..........#....", "...#.#.#......#....#.##..#..##.", "....##.#....#..#...##....###...", "##.#.###.....#..#.#.#..#.....##", "##..#.#........#...#..#.#......", "....#.#.......##.#...........#.", ".......##...#...#...#.....#....", ".....#....#..#..###.#...#......", "............#.#..#......#.#....", "...##..#.##....##..##.#......#.", "#.#.#......#.#.....#.#.#..#.#.#", "...###..........#..#..#.##.....", "......#......#......###..##....", "#...##...#....#....#..#...#.#..", ".......#..#......##.......#....", "...#..#..#.....#.....#......##.", "..#....###..........##..#...#..", "..........#..#.#...#......#..#.", "#...#....#.##.........#.#.#...#", ".#.#.#...#.#...#.#..#..#....#.#", "#.##....#..#.........#.##.##..#", "..#.#..##.#....#.###.#...#....#", ".#.......#...#.#.........#....#", ".......#...#..........#.#..#...", "...#.....##..#....#...###...#.#", "#....##.##..........#.......#..", ".##..##......#...#....#.##....#", "....#.....##...##.#..#.........", "...#.#..##.#.#..#.......#....#.", ".#...#.#.#.#..#..#.##.......#..", "..#..##...#.#..#.......#.#####.", ".......#.#...........#....#.#..", ".#.###..........#...#..#...#...", "..#.#............##......##....", "...##..#...###...##....#.#.##..", "....#.##...#..#.#.#...........#", "....#..#....##.....#.##.#.....#", "..##......##.#.........#....#.#", "###...#...#..#.#...#...........", ".####.....#.....#.#....#..#....", ".#....#..#..#..#...##.....###.#", "#....##.#....#.##..#......##..#", ".........#..#.#.....#.#....##.#", ".....#.#...#....#.#...#....#..#", ".#...#.#.....#.#......#.#......", "#....##.......#.............#..", "#..#...#........##..#..#......#", "####..##.#..##..#.........####.", ".#.##..#.#..#.#.#.##...#..#.#.#", ".##.#..#............#......#...", "###....#.##....#..#...#........", ".....#..###..........#..#......", ".##..##.....#..##....#...#.....", "#...##...........#..#...###..#.", "#..##....#...#.##.##....#......", "...#...#..#.#.......##.......##", "....#.....#..#...#.........#.#.", ".#...##.#......#.#..#..#...##..", "...##...##.##...##...#..#......", "#..##.#..#..#............#...#.", "..#.....#.........#........#.#.", "#.#...#...#......#.#......#....", ".##.....##.#.#....#.##...##.#..", ".##..##.#.#....#.##............", ".#.##.....##.#...#...###....#..", ".#..............#.#....###.###.", "....#..#...#.#.#..........#.#.#", ".#.#..#.#.#...###..#...##......", ".#.#.....###......#..........#.", "........#.##...............#.#.", "...#.#.#......#..#..##........#", "..#.##......#.......#..#......#", "...#...#...#...#..#..#........#", "..#....#.....#....#..##........", ".....#..#...##....#......##....", "...##..##..#..........##....#.#", "..#....#..#...#.##..#.....##...", "###...#.#....#........#.......#", "......#...#..#....###.........#", "..###.#...#...#...#.#..###.#...", ".##.#.......#.#..#..#......#.#.", "...##...........#.#..#.#..#....", ".......#.....####.#.....#...#.#", "......##......##.#.#.#...#.#..#", "..###.#####..#....#.#...#..##..", ".....#..#......#........#......", "#..##....#.#.##....#....#......", ".#....#.##.####.##..#..#......#", "#...##...#.#...##.#.##.##...#..", "........#.#........#.#...#..#..", ".#....###..#......#.##.###..#..", ".#..#..#..#..#...#.#.........##", "....#...#..#..............#....", "........#...##.....#.......#...", "..#......#.#..#.#..#.#.#...###.", "....#...####....###....#......#", "#...#.#...................#.##.", "..#.#.###...#....##....##......", "#..##..#.........#....#....####", ".#....###...#.#...#......#...#.", "......#..#.#..#.##...#.#.#..#..", ".#...#.#.....#..##......#..#...", "##.#..##.....##.#.#.......##...", ".##.##.##..#...#.#.##.##.......", ".#.#......#.....#...#.#..#.....", "...#...........#..#.##..##..#..", ".....#...##......#........#.#..", "....#..............##.........#", "..####.#....##..##......##.#.#.", ".#.#..#...#..........#...###..#", "....#.#.##.....###.#..#.##.....", ".......##.#.#..#...#...##.#....", "...#.##.....#....#...#...#.....", "##.#.##..#..#.#.....#.#..#.....", "..#..##........#....###..#..#..", "..#.........##.....#......#...#", "...##..........##......#.#.#...", "#.....#..#..#......#......#....", ".##...#..##....#.......##..#.#.", ".#...##...##......####.##.#....", ".....#.........#.#.####......#.", "...#.....#.#.........##..#.....", "##.#.###.#..#.#..#............#", "...##..#.#....#....#..#........", "..#.###......#...#.#.....#...#.", "....##.##..#.....#...#.#.#....#", ".......#.#..#...........#.#....", ".#.#..##.#.......#.#..#.....###", "...#.#.....#.#..#.##..#...#.#..", "...#......##....#..............", "......#...#....................", "..#........#...##.##.#..#.#.#..", ".#.###.#.##..##..#....##....#..", ".....#..#.#...#.#..#..#.......#", "..........#.##.#..##..####.....", "............#.#......#.........", ".#....#..#......#.....##.......", ".....#........#.....##.#..#.#..", "#..#.##...#.#.....#...#.####...", "......#...#....#.##..##.#...#..", ".#.#.##......##....#.#....#.##.", "#.#.#....#.###....##....##.....", ".##..#...#.##......#..#..#...##", "...#....###....#...........#.#.", "#.#.##.##...##....#....##.#...#", ".#.#######.......#......#......", "#......#...#.#.#.###....#.##..#", "......##..#..##.........##.#.##", "....##...#.#....##.....#.....#.", "..#.#........##........#.#..##.", ".....#..#.##.....#.....#..#.#..", ".#..............#.......#......", ".............#..#..........#...", ".#..#.##....##.#..#...##.......", "...........#..#.......#.#....#.", ".#..#..........##...#.#.#...#..", "......#....#..###....#......#..", ".#...#...##..#..#..##..#..#.#..", "#.#.........#....#..........##.", "...##..#..##...#....##...##.##.", "..#....#.####.........#.....##.", ".....#.#...#.#...#.##.#...##..#", "#...#.....#..#.......#...#..#..", "..#.......#..##.#.....#....#...", ".#.....#..##.#.....#...#.#...#.", ".....#.##..........##....#...#.", "...#....#...#........##...#...#", "....##...#....#..........#.....", "...#....##..#..####..##.#...#.#", "#...###.###..#....##.#.........", ".#.......#......#.........#....", "..#..##..#.........##..........", "#......#.#.##...#...#####......", "......#.....####......#....#...", ".........#..#..#...#....#.#....", "....#........#...##....#.......", "...##.#...#..........#....#....", "........#.......#.##..#..#...#.", "....#..##...........#.....#..#.", "#....#...............#.#....#..", ".#........#....#.#...#.......#.", "#.......##..........#.......#..", "...#....#...##.#..#.......#....", "#..#.##...#.#...#...#...#....#.", "###...#...#....#....#....#...#.", "##......#.#.......#....#..#....", "......#......#....#.#.#..###..#", ".#.#.##.....#..#..........#....", "##...#.#.#..##....#.....#.#....", "#.##...#...#.#...####..#.......", ".....##..#.#.#....#..##..#.#...", "....###.#.........##.....#.....", "......##...........#........#.#", ".#.........##..................", ".........##...#.............#.#", "......##...#...#.........#..##.", "#..#.......#..##.......###.....", "....#.#.....#............##....", ".....#..#......#....#.....##...", "##......##...................#.", "#....#............#.#.###.##...", ".#.....#........#.....#...#....", "......##.......######......##..", ".#....##....#..###....#.......#", "..............##.#..#.......#.#", ".#..#..........#..#.##.........", "......##.#..#......#.#....##.#.", "#.....#.##...#.....#...#..#...#", ".#....#..##.....#.....#.#.#....", "..#......#.##..#.........#.#.#.", ".#..##...#...#.....#..#..#.#..#", "#.#.##.##.................#.#.#", ".#..#.#..##.#.......#.......##.", "#...#...#..##...#...##...#...#.", "....#......#..#...#.....##..#..", "..............##......#...#.#..", "..##..#.......#..#..###.#.#....", ".#..#..#...#.......#...#...##.#", ".#...#.......###..#.##.###.....", "##.#...#......#.....#..#.......", "##....##............#.....#..#.", ".....#...##......##.....#....##", "#...##..#....#..##....###.#...#", ".....#..#.#.....#.##..##....#..", ".#.....#.#........#...#.#......", "......#....#.#........#.#......", ".##..#...............###...##.#", ".......###.#.#......###.....#..", ".......#..##...#....#.##..#.##.", "..#.......##.......#.....#....#", ".#......#....#..##..#.#.#..##..", "###......#...#..#.............#", ".#....#..#.#......##...........", ".#....#.##.....#..#.......#..##", "....#...#...#..#.....#..##..#.#", "#.#.#.......##.#..#.#....#.....", "##.#.......#...#...#.#......##.", "#....#.#...........#######.....", "...#.#.##.#......##..###.......", "..#.#....#..#.................#", "........#..##..#.....#....#.##.", "...#.#..#..#..#..............##", ".##.......###.#......#....#..##", "..##.##.#......#....#..#...#..#" };
            Double[] x = new Double[] { 1, 1, 3, 5, 7 };
            int y = 0;
            Double r = 0;
            while (y < input.Length)
            {
                foreach (Double i in x)
                {
                    if (Countx == 0)
                    {
                        r = (y * i) / 2;
                    }
                    else
                    {
                        r = y * i;
                    }

                    if (r == Convert.ToDouble(0))
                    {
                        r = y;
                    }
                    if (r % 1 != 0)
                    {
                        Countx++;
                        continue;
                    }
                    else
                    {
                        while (r >= input[y].Length)
                        {
                            r = r - input[y].Length;
                        }

                        if (input[y].Substring(Convert.ToInt32(r), 1) == "#")
                        {
                            tree[Countx]++;
                        }
                        else
                        {
                            square[Countx]++;
                        }
                    }
                    Countx++;
                }
                Countx = 0;
                y++;
            }
            UInt64 result = 1;
            string s = "";
            foreach (int i in tree)
            {
                result *= (ulong)i;
            }
            Console.WriteLine("result: " + result);
        }
    }
}