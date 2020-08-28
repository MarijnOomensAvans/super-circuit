using SuperCircuit.Visitor;
using System.Collections.Generic;

namespace SuperCircuit.Models
{
    public abstract class Node
    {
        //The composite pattern is used with Node as the parent abstract class which can be inherited.
        //Within this class it is possible to define a composite pattern in which the children classes can acces each other.
        public Node()
        {

        }

        public Node(string name)
        {
            Name = name;
        }

        public abstract void Accept(HUDVisitor v);

        public INodeValue Value { get; set; } = new NoneValue();

        public List<string> inputValues = new List<string>();

        public List<Node> outputNodes = new List<Node>();

        public int InputCount = 0;

        public string Name { get; set; }

        //this method uses the prototype pattern, the class itself knows how to build itself
        public abstract Node Clone(string name, INodeValue value);

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
