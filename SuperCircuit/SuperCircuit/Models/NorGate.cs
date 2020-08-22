using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    class NorGate : IGate
    {
        public NodeValue execute()
        {
            NodeValue value = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On && value != NodeValue.Off)
                {
                    value = NodeValue.On;
                }
                else
                {
                    value = NodeValue.Off;
                }
            }

            Value = value;
            return value;
        }
    }
}
