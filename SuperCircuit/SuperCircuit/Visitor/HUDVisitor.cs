using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Visitor
{
    public class HUDVisitor: Visitor
    {
        public void visit(InputNode node)
        {
            Console.WriteLine("this is a InputNode");
        }

        public void visit(OutputNode node)
        {
            Console.WriteLine("this is a OutputNode");
        }

        public void visit(Node node)
        {
            Console.WriteLine("this is a "+node.Name+" Node");
        }
    }
}
