using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    class AndGate : Node
    {
        public AndGate()
        {

        }

        public AndGate(string name) : base(name)
        {

        }
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On && nodeValue != NodeValue.Off)
                {
                    nodeValue = NodeValue.On;
                }
                else
                {
                    nodeValue = NodeValue.Off;
                }
            }

            Value = nodeValue;
            return nodeValue;
        }
    }
}
