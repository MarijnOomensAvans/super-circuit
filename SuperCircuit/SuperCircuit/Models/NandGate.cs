using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    class NandGate : IGate, Node
    {
        public NodeValue execute()
        {
            NodeValue value = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On && value != NodeValue.On)
                {
                    value = NodeValue.Off;
                } else
                {
                    value = NodeValue.On;
                }
            }

            Value = value;
            return value;
        }
    }
}
