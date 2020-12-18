namespace AoC2015.Solutions.Day07
{
    public class Part01 : ISolution
    {
        public string Solve(string input)
        {
            var circuit = new Circuit(input);
            IWire targetWire = circuit.Wires["a"];
            return targetWire.GetOutput(circuit.Wires).ToString();
        }
    }
}
