﻿namespace AoC2015.Solutions.Day07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Circuit
    {
        public Circuit(string input)
        {
            string[] instructions = input
                .Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string instruction in instructions)
            {
                string[] components = instruction.Split(' ');

                string name = components[^1];

                if (components[0] == "NOT")
                {
                    this.Wires[name] = new NotGateInputWire(name, components[1]);
                }
                else if (components[1] == "AND")
                {
                    this.Wires[name] = new AndGateInputWire(name, components[0], components[2]);
                }
                else if (components[1] == "OR")
                {
                    this.Wires[name] = new OrGateInputWire(name, components[0], components[2]);
                }
                else if (components[1] == "LSHIFT")
                {
                    this.Wires[name] = new LeftShiftGateInputWire(name, components[0], int.Parse(components[2]));
                }
                else if (components[1] == "RSHIFT")
                {
                    this.Wires[name] = new RightShiftGateInputWire(name, components[0], int.Parse(components[2]));
                }
                else if (int.TryParse(components[0], out int val))
                {
                    this.Wires[name] = new DirectInputWire(name, val);
                }
                else
                {
                    this.Wires[name] = new PassThroughWire(name, components[0]);
                }
            }
        }

        public IDictionary<string, IWire> Wires { get; } = new Dictionary<string, IWire>();
    }
}
