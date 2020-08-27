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

        public NandGate(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            NodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node == "Off" && nodeValue.getValue() != "On")
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

        public override Node clone(string name, NodeValue value)
        {
            return new AndGate(name, value);
        }

    }
}
