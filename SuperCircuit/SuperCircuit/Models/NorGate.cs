using SuperCircuit.Visitor;
using System;

namespace SuperCircuit.Models
{
    public class NorGate : Node
    {

        public NorGate()
        {

        }

        public NorGate(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            NodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node == "On" && nodeValue.getValue() != "Off")
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
            return new NorGate(name, value);
        }
    }
}
