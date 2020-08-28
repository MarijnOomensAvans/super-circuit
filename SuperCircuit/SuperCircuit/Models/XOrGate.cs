using SuperCircuit.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class XOrGate : Node
    {

        public XOrGate()
        {

        }

        public XOrGate(string name, INodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            INodeValue nodeValue = new NoneValue();
            string valueForHighCurrent = new NoneValue().GetValue();

            foreach (var node in inputValues)
            {

                if (valueForHighCurrent == new NoneValue().GetValue())
                {
                    valueForHighCurrent = node;
                    nodeValue = new OnValue();
                }
                else if (node == valueForHighCurrent && nodeValue.GetValue() == "On")
                {
                    nodeValue = new OnValue();
                }
                else
                {
                    nodeValue = new OffValue();
                }

            }
            Value = nodeValue;
            Console.WriteLine(Name + " -- " + Value.GetValue());
            return nodeValue.GetValue();
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override Node Clone(string name, INodeValue value)
        {
            return new XOrGate(name, value);
        }
    }
}
