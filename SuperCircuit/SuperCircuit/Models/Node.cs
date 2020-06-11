using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class Node
    {
        public NodeValue Value { get; set; } = NodeValue.None;

        public List<NodeValue> inputValues = new List<NodeValue>();

        public void Execute(NodeValue value)
        {
            if(value == NodeValue.None)
            {
                return;
            }

            inputValues.Add(value);
        }
    }
}
