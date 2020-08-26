using SuperCircuit.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    class NandGate : Node
    {
        public NandGate()
        {

        }

        public NandGate(string name) : base(name)
        {

        }
        public override string CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node.getValue() == "Off" && nodeValue.getValue() != "On")
                {
                    nodeValue = new OffValue();
                }
                else
                {
                    nodeValue = new OnValue();
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
            return new AndGate((Name = name));
        }

    }
}
