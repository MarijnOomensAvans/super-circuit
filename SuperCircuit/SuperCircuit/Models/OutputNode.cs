using SuperCircuit.Models;
using SuperCircuit.Visitor;
using System;

namespace SuperCircuit
{
    public class OutputNode : Node
    {

        public OutputNode()
        {
        }

        public OutputNode(string name, INodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;

        }
        public override string CalculateOutput(string value)
        {
            if (value == "On")
            {
                Value = new OnValue();
            } else
            {
                Value = new OffValue();
            }
            Console.WriteLine(Name + " -- " + Value.GetValue());
            Console.WriteLine(Name + " has finished with status " + Value.GetValue());
            return value;
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override Node Clone(string name, INodeValue value)
        {
            return new OutputNode(name, value);
        }
    }
}