namespace AoC2015.Solutions.Day07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DirectInputWire : IWire
    {
        private readonly int value;

        public DirectInputWire(string name, int value)
        {
            this.Name = name;
            this.value = value;
        }

        public string Name { get; }

        public int GetOutput(IDictionary<string, IWire> wires) => this.value;
    }
}
