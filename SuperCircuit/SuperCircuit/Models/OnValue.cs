using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Models
{
    public class OnValue : INodeValue
    {
        public string GetValue()
        {
            return "On";
        }
    }
}
