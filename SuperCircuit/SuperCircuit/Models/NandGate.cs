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
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;

            foreach (var node in inputValues)
            {
                if (node == NodeValue.On && nodeValue != NodeValue.On)
                {
                    nodeValue = NodeValue.Off;
                }
                else
                {
                    nodeValue = NodeValue.On;
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
