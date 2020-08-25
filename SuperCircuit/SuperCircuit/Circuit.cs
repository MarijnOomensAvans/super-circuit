using SuperCircuit.Models;
using System;
using System.Collections.Generic;

namespace SuperCircuit
{
    internal class Circuit
    {
        public List<Node> nodes = new List<Node>();
        public List<InputNode> inputNodes = new List<InputNode>();
        public List<OutputNode> outputNodes = new List<OutputNode>();

        public Circuit()
        {
            nodes = new List<Node>();
            inputNodes = new List<InputNode>();
            outputNodes = new List<OutputNode>();
        }

        public void AddNode(Node node)
        {
            nodes.Add(node);
        }

        public void AddInputNode(InputNode node, NodeValue value)
        {
            node.Value = value;
            inputNodes.Add(node);
        }

        public void AddOutputNode(OutputNode node)
        {
            outputNodes.Add(node);
        }

        public void StartCircuit()
        {
            foreach (var node in inputNodes)
            {
                node.Execute(node.Value);
            }
        }

        internal void AddEdge(string edge)
        {
            Console.WriteLine(edge);
        }
    }

}