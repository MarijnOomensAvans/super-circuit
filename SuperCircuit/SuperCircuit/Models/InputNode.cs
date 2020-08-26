using SuperCircuit.Models;
using SuperCircuit.Visitor;
using System;
using System.Reflection.Emit;

namespace SuperCircuit
{
    public class InputNode : Node
    {
        public InputNode()
        {

        }

        public InputNode(string name) : base(name)
        {

        }

        public InputNode(NodeValue value)
        {
            Value = value;
            InputCount = 1;
        }

        public override NodeValue CalculateOutput(NodeValue value)
        {
            return value;
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}