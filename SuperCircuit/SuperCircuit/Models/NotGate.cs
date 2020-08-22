using System;

namespace SuperCircuit.Models
{
    class NotGate : Node
    {
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;

            if (value == NodeValue.Off)
            {
                nodeValue = NodeValue.On;
            }
            else
            {
                nodeValue = NodeValue.Off;
            }

            Value = nodeValue;
            return nodeValue;
        }

    }
}
