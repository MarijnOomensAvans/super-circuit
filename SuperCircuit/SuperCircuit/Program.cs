using System;

namespace SuperCircuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var circuit = new CircuitBuilder().Build();
            circuit.StartCircuit();
        }
    }
}
