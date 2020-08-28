using SuperCircuit.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class NandGate : Node
    {

        public NandGate()
        {

        }

        public NandGate(string name, INodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            INodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node == "Off" && nodeValue.GetValue() != "On")
                {
                    nodeValue = new OffValue();
                }
                else
                {
                    nodeValue = new OnValue();
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
            return new AndGate(name, value);
        }

    }
}
