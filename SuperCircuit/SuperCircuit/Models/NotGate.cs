using SuperCircuit.Visitor;
using System;

namespace SuperCircuit.Models
{
    public class NotGate : Node
    {

        public NotGate()
        {

        }

        public NotGate(string name, INodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            INodeValue nodeValue = new NoneValue();

            if (value == "Off")
            {
                nodeValue = new OnValue();
            }
            else
            {
                nodeValue = new OffValue();
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
            return new NotGate(name,value);
        }

    }
}
