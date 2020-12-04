using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Day4.Part2();
            return;
            Console.WriteLine("Select day (1-25) and Part(1-2) (day.part) : ");
            string input = Console.ReadLine();
            try
            {
                switch (input)
                {
                    case "1.1": Day1.Part1(); break;
                    case "1.2": Day1.Part2(); break;
                    case "2.1": Day2.Part1(); break;
                    case "2.2": Day2.Part2(); break;
                    case "3.1": Day3.Part1(); break;
                    case "3.2": Day3.Part2(); break;
                    case "4.1": Day4.Part1(); break;
                    case "4.2": Day1.Part1(); break;
                }

            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            goto Start;

        }

    }

}
