using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit.Factories
{
    public class NodeFactory
    {
        public Dictionary<string, Node> _types;

        public NodeFactory(Dictionary<string, Node> typesCollection)
        {
            _types = typesCollection;
        }

        public Node CreateNode(string nodeName, string nodeType)
        {
            Node n = _types[nodeType];
            return n.Clone(nodeName,n.Value);
        }
    }
}
