namespace AoC2015.Solutions.Day07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PassThroughWire : IWire
    {
        private readonly string input;

        public PassThroughWire(string name, string input)
        {
            this.Name = name;
            this.input = input;
        }

        public string Name { get; }

        public int GetOutput(IDictionary<string, IWire> wires) => wires[this.input].GetOutput(wires);
    }
}
