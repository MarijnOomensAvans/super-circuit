using SuperCircuit.Factories;
using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using View;

namespace SuperCircuit
{
    internal class CircuitBuilder
    {
        private Circuit _circuit;
        private NodeFactory _factory;

        public CircuitBuilder()
        {
            Reset();
            Dictionary<string, Node> _types = new Dictionary<string, Node>()
            {
                    {"INPUT_HIGH", new InputNode(NodeValue.On) },
                    {"INPUT_LOW", new InputNode(NodeValue.Off) },
                    {"PROBE", new OutputNode() },
                    {"OR", new OrGate() },
                    {"NOR", new NorGate() },
                    {"AND", new AndGate() },
                    {"NAND", new NandGate() },
                    {"NOT", new NotGate() },
                    {"XOR", new XOrGate() },
            };
        }

        public void Reset()
        {
            _circuit = new Circuit();
        }

        public void Build()
        {
            this._circuit = new Circuit();
            List<string> circuitText = new FileParser().ReadCircuit();
            foreach (var def in circuitText)
            {
                AddNode(def);
            }
        }

        public void AddNode(string definition)
        {
            string aaaa = definition.Split(":")[1];
            string bbbb = definition.Split(":")[0];

            string type = aaaa.TrimEnd(new char[] { ';' }).TrimStart(new char[] { '\t' });
            string name = bbbb.TrimEnd(new char[] { ';' }).TrimStart(new char[] { '\t' });

            _factory.CreateNode(type, name);
        }

        public Circuit GetCircuit()
        {
            Reset();

            return _circuit;
        }
    }
}