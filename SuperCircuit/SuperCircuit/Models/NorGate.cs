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
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On && nodeValue != NodeValue.Off)
                {
                    nodeValue = NodeValue.On;
                }
                else
                {
                    nodeValue = NodeValue.Off;
                }
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
