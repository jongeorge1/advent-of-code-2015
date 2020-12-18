﻿namespace AoC2015.Solutions.Day07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RightShiftGateInputWire : IWire
    {
        private readonly string input1;
        private readonly int input2;
        private int? signal;

        public RightShiftGateInputWire(string name, string input1, int input2)
        {
            this.Name = name;
            this.input1 = input1;
            this.input2 = input2;
        }

        public string Name { get; }

        public int GetOutput(IDictionary<string, IWire> wires)
        {
            return this.signal ??= wires[this.input1].GetOutput(wires) >> this.input2;
        }
    }
}
