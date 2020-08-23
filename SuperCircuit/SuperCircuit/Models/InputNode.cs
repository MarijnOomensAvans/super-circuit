using SuperCircuit.Models;
using System.Reflection.Emit;

namespace SuperCircuit
{
    public class InputNode : Node
    {
        public InputNode(NodeValue value)
        {
            Value = value;
            InputCount = 1;
        }

        public override NodeValue CalculateOutput(NodeValue value)
        {
            return value;
        }
    }
}