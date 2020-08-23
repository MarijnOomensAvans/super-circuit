using SuperCircuit.Models;

namespace SuperCircuit
{
    public class OutputNode : Node
    {
        public override NodeValue CalculateOutput(NodeValue value)
        {
            Value = value;
            return value;
        }
    }
}