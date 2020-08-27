using SuperCircuit.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class AndGate : Node
    {

        public AndGate()
        {

        }
        
        public AndGate(string name, NodeValue value) : base(name)
        {
            this.Name = name;
            this.Value = value;
        }
        public override string CalculateOutput(string value)
        {
            NodeValue nodeValue = new NoneValue();

            foreach (var node in inputValues)
            {
                if (node == "On" && nodeValue.getValue() != "Off")
                {
                    nodeValue = new OnValue();
                }
                else
                {
                    nodeValue = new OffValue();
                }
            }
            Value = nodeValue;
            Console.WriteLine(Name + " -- " + Value.getValue());
            return nodeValue.getValue();
        }
         
        public override void Accept(HUDVisitor visitor)
        {

            visitor.visit(this);
        }

        public override Node clone(string name, NodeValue value)
        {
            return new AndGate(name, value);
        }
    }
}
