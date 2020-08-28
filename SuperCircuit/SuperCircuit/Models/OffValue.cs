using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class OffValue : INodeValue
    {
        public string GetValue()
        {
            return "Off";
        }
    }
}
