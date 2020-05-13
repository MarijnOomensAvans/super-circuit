using SuperCircuit;
using System;
using System.Diagnostics;

namespace View
{
    public class FileParser
    {
        internal Circuit ReadCircuit()
        {
            Circuit parsedCircuit = new Circuit();

            string[] list = new FileReader().ReadFile("Circuit1_FullAdder");

            foreach (var sentence in list)
            {
                Console.WriteLine(sentence);
            }

            return new Circuit();
        }
    }
}