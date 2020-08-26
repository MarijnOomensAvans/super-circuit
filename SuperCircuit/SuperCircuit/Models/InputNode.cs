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

        public override string CalculateOutput(NodeValue value)
        {
            return value.getValue();
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}