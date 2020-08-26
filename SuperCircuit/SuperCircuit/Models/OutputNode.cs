using SuperCircuit.Models;
using SuperCircuit.Visitor;
using System;

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
        public override string CalculateOutput(NodeValue value)
        {
            Value = value;
            return value.getValue();
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}