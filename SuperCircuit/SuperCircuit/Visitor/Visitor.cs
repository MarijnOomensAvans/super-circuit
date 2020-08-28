using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Visitor
{
    interface IVisitor
    {

        public void Visit(InputNode v);

        public void Visit(OutputNode v);

        public void Visit(Node v);
    }
}
