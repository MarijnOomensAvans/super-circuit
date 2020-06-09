using SuperCircuit;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace View
{
    public class FileParser
    {
        internal List<string> ReadCircuit()
        {
            List<string> circuitDefinitions = new List<string>();
            Circuit parsedCircuit = new Circuit();

            string[] list = new FileReader().ReadFile("Circuit1_FullAdder");

            foreach (var sentence in list)
            {
                if (sentence != "")
                {
                    if(!(sentence[0] == '#'))
                    {
                        circuitDefinitions.Add(sentence);
                    }
                }
            }

            return circuitDefinitions;
        }
    }
}