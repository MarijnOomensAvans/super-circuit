using SuperCircuit.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    class XOrGate : Node
    {

        public XOrGate()
        {

        }

        public XOrGate(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            NodeValue nodeValue = new NoneValue();
            string valueForHighCurrent = new NoneValue().getValue();

            foreach (var node in inputValues)
            {

                if (valueForHighCurrent == new NoneValue().getValue())
                {
                    valueForHighCurrent = node;
                    nodeValue = new OnValue();
                }
                else if (node == valueForHighCurrent && nodeValue.getValue() == "On")
                {
                    nodeValue = new OnValue();
                }
                else
                {
                    nodeValue = new OffValue();
                }

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
            return new XOrGate(name, value);
        }
    }
}
