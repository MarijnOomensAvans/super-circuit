namespace SuperCircuit.Models
{
    class OrGate : Node
    {
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On || nodeValue == NodeValue.On)
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
