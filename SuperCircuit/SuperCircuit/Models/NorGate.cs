using SuperCircuit.Visitor;
using System;

namespace SuperCircuit.Models
{
    class NorGate : Node
    {
        public NorGate()
        {

        }

        public NorGate(string name) : base(name)
        {

        }
        public override string CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node.getValue() == "On" && nodeValue.getValue() != "Off")
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
            return new NorGate((Name = name));
        }
    }
}
