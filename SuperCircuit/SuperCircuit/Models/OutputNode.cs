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

        public OutputNode(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;

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

        public override Node clone(string name, NodeValue value)
        {
            return new OutputNode(name, value);
        }
    }
}