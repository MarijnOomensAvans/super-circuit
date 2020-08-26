using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class NoneValue : NodeValue
    {
        public string getValue()
        {
            return "none";
        }
    }
}
