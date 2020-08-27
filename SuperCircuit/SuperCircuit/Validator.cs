﻿using SuperCircuit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit
{
    public class Validator
    {

        public bool Validate(List<Node> nodeList)
        {
            bool hasError = false;
            foreach (Node currentNode in nodeList)
            {
                int connections = 0;

                foreach (Node node in nodeList)
                {
                    foreach (Node connectedNode in node.outputNodes)
                    {
                        if (connectedNode.Equals(currentNode)) { connections++; }
                    }
                }
                if (currentNode is NotGate || currentNode is OutputNode)
                {
                    if (connections == 1) { continue; }
                    else { hasError = true; Console.WriteLine("Warning, not all nodes are connected."); break; }
                }
                else if (currentNode is InputNode) { continue; }
                else
                {
                    if (connections == 2) { continue; }
                    else if (connections == 1 || connections == 0) { hasError = true; Console.WriteLine("Warning, not all nodes are connected."); break; }
                    else { hasError = true; Console.WriteLine("Warning, an infinite loop was detected."); break; }
                }
            }
            return hasError;
        }
    }
}