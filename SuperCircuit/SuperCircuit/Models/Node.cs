using SuperCircuit.Visitor;
using System.Collections.Generic;

namespace SuperCircuit.Models
{
    public abstract class Node
    {
        public Node()
        {

        }

        public Node(string name)
        {
            Name = name;
        }

        public abstract void Accept(HUDVisitor v);

        public NodeValue Value { get; set; } = new NoneValue();

        public List<string> inputValues = new List<string>();

        public List<Node> outputNodes = new List<Node>();

        public int InputCount = 0;

        public string Name { get; set; }

        //prototype, the class itself knows how to build itself
        public abstract Node clone(string name, NodeValue value);

        //this is a method using the template pattern
        public abstract string CalculateOutput(string value);

        public void Execute(string value)
        {
            if(value != "Off" && value != "On")
            {
                return;
            }

            inputValues.Add(value);

            if (InputCount == inputValues.Count)
            {
                var output = CalculateOutput(value);

                foreach (var node in outputNodes)
                {
                    node.Execute(output);
                }
            }
        }

        public void AddOutput(Node output)
        {
            outputNodes.Add(output);
            output.IncreaseInput();
        }

        public void IncreaseInput()
        {
            InputCount += 1;
        }
    }
}
