using SuperCircuit.Visitor;
using System;

namespace SuperCircuit.Models
{
    public class NorGate : Node
    {

        public NorGate()
        {

        }

        public NorGate(string name, INodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            INodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node == "On" && nodeValue.GetValue() != "Off")
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
            return new NorGate(name, value);
        }
    }
}
