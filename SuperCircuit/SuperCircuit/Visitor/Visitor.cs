using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Visitor
{
    interface Visitor
    {

        public void visit(InputNode v);

        public void visit(OutputNode v);

        public void visit(Node v);
    }
}
