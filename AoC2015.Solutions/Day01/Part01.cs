﻿namespace AoC2015.Solutions.Day01
{
    using System.Linq;

    public class Part01 : ISolution
    {
        public string Solve(string input)
        {
            return (input.Count(x => x == '(') - input.Count(x => x == ')')).ToString();
        }
    }
}
