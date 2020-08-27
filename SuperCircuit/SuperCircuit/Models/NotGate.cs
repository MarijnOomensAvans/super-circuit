using SuperCircuit.Visitor;
using System;

namespace SuperCircuit.Models
{
    class NotGate : Node
    {

        public NotGate()
        {

        }

        public NotGate(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            NodeValue nodeValue = new NoneValue();

            if (value == "Off")
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

        public override Node clone(string name, NodeValue value)
        {
            return new NotGate(name,value);
        }

    }
}
