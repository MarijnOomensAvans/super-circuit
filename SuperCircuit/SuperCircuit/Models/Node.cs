using System.Collections.Generic;

namespace SuperCircuit.Models
{
    public abstract class Node
    {
        public NodeValue Value { get; set; } = NodeValue.None;

        public List<NodeValue> inputValues = new List<NodeValue>();

        public List<Node> outputNodes = new List<Node>();

        public int InputCount = 0;

        public abstract NodeValue CalculateOutput(NodeValue value);

        public void Execute(NodeValue value)
        {
            if(value != NodeValue.Off && value != NodeValue.On)
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
