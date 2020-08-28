using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Visitor
{
    public class HUDVisitor: IVisitor
    {
        public void Visit(InputNode node)
        {
            Console.WriteLine("Selected node: " + node.Name + ". This is an input node. Connected to:");
            foreach (var output in node.outputNodes)
            {
                Console.WriteLine(output.Name);
            }
        }

        public void Visit(OutputNode node)
        {
            Console.WriteLine("Selected node: " + node.Name + ". The selected node is an output node, so it is not connected to any other nodes.");
        }

        public void Visit(Node node)
        {
            Console.WriteLine("Selected node: " + node.Name);
            Console.WriteLine("Node " + node.Name + " is connected to:");
            foreach (var output in node.outputNodes)
            {
                Console.WriteLine(output.Name);
            }
        }
    }
}
