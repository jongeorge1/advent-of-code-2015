namespace AoC2015.Solutions.Day07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IWire
    {
        public string Name { get; }

        int GetOutput(IDictionary<string, IWire> wires);
    }
}
