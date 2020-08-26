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
        public override NodeValue CalculateOutput(NodeValue value)
        {
            NodeValue nodeValue = NodeValue.None;
            NodeValue valueForHighCurrent = NodeValue.None;

            foreach (var node in inputValues)
            {

                if (valueForHighCurrent == NodeValue.None)
                {
                    valueForHighCurrent = node;
                    nodeValue = NodeValue.On;
                }
                else if (node == valueForHighCurrent && nodeValue == NodeValue.On)
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
