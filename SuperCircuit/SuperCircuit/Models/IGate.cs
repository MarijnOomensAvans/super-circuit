using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    interface IGate
    {
        public NodeValue execute(NodeValue inputValue);
    }
}
