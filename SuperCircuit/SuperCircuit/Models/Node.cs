using System.Collections.Generic;

namespace SuperCircuit.Models
{
    public abstract class Node
    {
        public NodeValue Value { get; set; } = NodeValue.None;

        public List<NodeValue> inputValues = new List<NodeValue>();

        public List<Node> outputNodes = new List<Node>();

        public abstract NodeValue CalculateOutput(NodeValue value);

        public void Execute(NodeValue value)
        {
            if(value == NodeValue.None)
            {
                return;
            }

            inputValues.Add(value);
        }

        public void AddOutpu(Node output)
        {
            outputNodes.Add(output);
        }
    }
}
