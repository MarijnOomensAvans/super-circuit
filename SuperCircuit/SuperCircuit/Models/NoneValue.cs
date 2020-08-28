using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class NoneValue : INodeValue
    {
        public string GetValue()
        {
            return "none";
        }
    }
}
