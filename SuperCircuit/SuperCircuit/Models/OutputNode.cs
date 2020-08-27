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

        public OutputNode(string name, NodeValue value) : base(name)
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
            Console.WriteLine(Name + " -- " + Value.getValue());
            Console.WriteLine(Name + " has finished with status " + Value.getValue());
            return value;
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }

        public override Node clone(string name, NodeValue value)
        {
            return new OutputNode(name, value);
        }
    }
}