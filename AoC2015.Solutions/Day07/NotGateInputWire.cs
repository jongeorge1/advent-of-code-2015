namespace AoC2015.Solutions.Day07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NotGateInputWire : IWire
    {
        private readonly string input;
        private int? signal;

        public NotGateInputWire(string name, string input)
        {
            this.Name = name;
            this.input = input;
        }

        public string Name { get; }

        public int GetOutput(IDictionary<string, IWire> wires)
        {
            return this.signal ??= ~wires[this.input].GetOutput(wires);
        }
    }
}
