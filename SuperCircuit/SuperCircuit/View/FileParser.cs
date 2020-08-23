using SuperCircuit;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace View
{
    public class FileParser
    {
        internal List<string> ReadCircuitNodes()
        {
            List<string> circuitDefinitions = new List<string>();

            string[] list = new FileReader().ReadFile("Circuit1_FullAdder");

            foreach (var sentence in list)
            {
                if (sentence != "")
                {
                    if (sentence == "# Description of all the edges")
                    {
                        break;
                    }
                    if(!(sentence[0] == '#'))
                    {
                        circuitDefinitions.Add(sentence);
                    }
                }
            }

            return circuitDefinitions;
        }

        internal List<string> ReadCircuitEdges()
        {
            List<string> edgeDefinitions = new List<string>();

            string[] list = new FileReader().ReadFile("Circuit1_FullAdder");

            bool isEdge = false;

            foreach (var sentence in list)
            {
                if (sentence != "")
                {
                    if (sentence == "# Description of all the edges")
                    {
                        isEdge = true;
                    }
                    if (!(sentence[0] == '#') && isEdge)
                    {
                        edgeDefinitions.Add(sentence);
                    }
                }
            }

            return edgeDefinitions;
        }
    }
}