using SuperCircuit.Models;
using SuperCircuit.Visitor;
using System;
using System.Reflection.Emit;

namespace SuperCircuit
{
    public class InputNode : Node
    {
        public InputNode(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }

        public InputNode(NodeValue value)
        {
            Value = value;
            InputCount = 1;
        }

        public override string CalculateOutput(NodeValue value)
        {
            return value.getValue();
        }

        public override void Accept(HUDVisitor visitor)
        {
            visitor.visit(this);
        }

        public override Node clone(string name, NodeValue value)
        {
            Console.WriteLine(value);
            return new InputNode(name,value);

        }
    }
}