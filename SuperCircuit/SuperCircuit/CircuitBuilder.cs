using SuperCircuit.Factories;
using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            _factory = new NodeFactory(_types);
        }

        public void Reset()
        {
            _circuit = new Circuit();
        }

        public void Build()
        {
            this._circuit = new Circuit();
            List<string> circuitText = new FileParser().ReadCircuitNodes();
            foreach (var def in circuitText)
            {
                AddNode(def);
            }

            List<string> curcuitEdges = new FileParser().ReadCircuitEdges();
            foreach (var edge in curcuitEdges)
            {
                AddEdge(edge);
            }
        }

        private void AddEdge(string edge)
        {
            Console.WriteLine(edge);
        }

        public void AddNode(string definition)
        {
            string aaaa = definition.Split(":")[1];
            string bbbb = definition.Split(":")[0];

            string type = aaaa.TrimEnd(new char[] { ';' });
            string name = bbbb.TrimEnd(new char[] { ';' });

            type = type.Replace("\t", String.Empty).Replace(" ", String.Empty);
            name = name.Replace("\t", String.Empty).Replace(" ", String.Empty);

            Console.WriteLine(type);

            _circuit.AddNode(_factory.CreateNode(name, type));
        }

        public Circuit GetCircuit()
        {
            Reset();

            return _circuit;
        }
    }
}