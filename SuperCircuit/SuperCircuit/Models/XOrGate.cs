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

        public XOrGate(string name) : base(name)
        {

        }
        public override string CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = new NoneValue();
            NodeValue valueForHighCurrent = new NoneValue();

            foreach (var node in inputValues)
            {

                if (valueForHighCurrent == new NoneValue())
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

        public override Node clone(string name)
        {
            return new XOrGate((Name = name));
        }
    }
}
