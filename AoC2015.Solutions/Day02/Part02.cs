﻿namespace AoC2015.Solutions.Day02
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Part02 : ISolution
    {
        public string Solve(string input)
        {
            return input
                .Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Split('x', StringSplitOptions.RemoveEmptyEntries))
                .Select(x => x.Select(int.Parse).ToList())
                .Sum(this.CalculateRequiredRibbon)
                .ToString();
        }

        private int CalculateRequiredRibbon(List<int> sides)
        {
            sides.Sort();
            int perimeter = (2 * sides[0]) + (2 * sides[1]);
            int volume = sides[0] * sides[1] * sides[2];

            return perimeter + volume;
        }
    }
}
