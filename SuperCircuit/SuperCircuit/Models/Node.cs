﻿using SuperCircuit.Visitor;
using System.Collections.Generic;

namespace SuperCircuit.Models
{
    public abstract class Node
    {
        public Node()
        {

        }

        public Node(string name)
        {
            Name = name;
        }

        public abstract void Accept(HUDVisitor v);

        public NodeValue Value { get; set; } = new NoneValue();

        public List<NodeValue> inputValues = new List<NodeValue>();

        public List<Node> outputNodes = new List<Node>();

        public int InputCount = 0;

        public string Name { get; set; }

        public abstract Node clone(string name);

        public abstract string CalculateOutput(NodeValue value);

        public void Execute(NodeValue value)
        {
            if(value.getValue() != "Off" && value.getValue() != "On")
            {
                return;
            }

            inputValues.Add(value);

            if (InputCount == inputValues.Count)
            {
                CalculateOutput(value);

                foreach (var node in outputNodes)
                {
                    node.Execute(value);
                }
            }
        }

        public void AddOutput(Node output)
        {
            outputNodes.Add(output);
            output.IncreaseInput();
        }

        public void IncreaseInput()
        {
            InputCount += 1;
        }
    }
}
