using SuperCircuit.Visitor;
using System;

namespace SuperCircuit.Models
{
    class NotGate : Node
    {
        public NotGate()
        {

        }

        public NotGate(string name) : base(name)
        {

        }
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;

            if (value == NodeValue.Off)
            {
                nodeValue = NodeValue.On;
            }
            else
            {
                nodeValue = NodeValue.Off;
            }

            Value = nodeValue;
            return nodeValue;
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }

    }
}
