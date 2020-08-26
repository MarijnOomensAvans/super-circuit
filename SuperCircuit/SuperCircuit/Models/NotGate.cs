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
        public override string CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = new NoneValue();

            if (value.getValue() == "Off")
            {
                nodeValue = new OnValue();
            }
            else
            {
                nodeValue = new OffValue();
            }

            Value = nodeValue;
            return nodeValue.getValue();
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }

    }
}
