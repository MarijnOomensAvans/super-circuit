﻿using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (node is InputNode)
            {
                inputNodes.Add((InputNode) node);
            }
            if (node is OutputNode)
            {
                outputNodes.Add((OutputNode) node);
            }
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
            var nodeString = edge.Split(":")[0];

            var node = nodes.Where(n => n.Name == nodeString).First();

            var after = nodeString = edge.Split(":")[1].TrimStart(new char[] { '\t' }).TrimEnd(new char[] { ';' });

            var connectedNodes = after.Split(",");

            foreach (var afterNode in connectedNodes)
            {
                node.AddOutput(this.nodes.Where(n => n.Name == afterNode).First());
            }
        }
    }

}