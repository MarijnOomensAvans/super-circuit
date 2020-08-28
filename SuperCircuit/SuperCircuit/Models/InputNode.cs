using SuperCircuit.Models;
using SuperCircuit.Visitor;
using System;
using System.Reflection.Emit;

namespace SuperCircuit
{
    public class InputNode : Node
    {
        public InputNode(string name, INodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
            InputCount = 1;
        }

        public InputNode(INodeValue value)
        {
            Value = value;
            InputCount = 1;
        }

        public override string CalculateOutput(string value)
        {
            Console.WriteLine(Name + " -- " + Value.GetValue());
            return value;
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override Node Clone(string name, INodeValue value)
        {
            return new InputNode(name,value);

        }
    }
}