using SuperCircuit.Models;

namespace SuperCircuit
{
    public class OutputNode : Node
    {
        public OutputNode()
        {

        }

        public OutputNode(string name) : base(name)
        {

        }
        public override NodeValue CalculateOutput(NodeValue value)
        {
            Value = value;
            return value;
        }
    }
}