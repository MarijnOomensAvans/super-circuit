using System.Collections.Generic;
using View;

namespace SuperCircuit
{
    internal class CircuitBuilder
    {
        private Circuit _circuit;

        public CircuitBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            this._circuit = new Circuit();
        }

        public void Build()
        {
            Circuit circuit = new Circuit();
            List<string> circuitText = new FileParser().ReadCircuit();
            foreach (var def in circuitText)
            {
                if(def[0] == 'N')
                {
                    AddNode(def);
                }
            }
        }

        public void AddNode(string definition)
        {
            this._circuit.AddNode(definition);
        }

        public Circuit GetCircuit()
        {
            Circuit circuit = this._circuit;

            Reset();

            return circuit;
        }
    }
}