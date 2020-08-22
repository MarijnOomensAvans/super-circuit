using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    class AndGate : IGate, Node
    {
        public NodeValue execute(NodeValue inputValue)
        {
            NodeValue value = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On && value != NodeValue.Off)
                {
                    value = NodeValue.On;
                } else
                {
                    value = NodeValue.Off;
                }
            }

            Value = value;
            return value;
        }
    }
}
