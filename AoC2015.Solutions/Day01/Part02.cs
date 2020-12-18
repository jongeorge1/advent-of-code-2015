﻿namespace AoC2015.Solutions.Day01
{
    using System.Linq;

    public class Part02 : ISolution
    {
        public string Solve(string input)
        {
            int floor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                floor += input[i] == '(' ? 1 : -1;
                if (floor == -1)
                {
                    return (i + 1).ToString();
                }
            }

            return string.Empty;
        }
    }
}
