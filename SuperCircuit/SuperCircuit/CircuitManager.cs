using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit
{
    public class CircuitManager
    {

        public bool valid = true;

        //Circuitmanager is made with the facade pattern, the structure does not need to change.
        public CircuitManager()
        {
            this.getInput();
        }

        private void getInput()
        {
            int input;
            while (valid) { 
            Console.WriteLine("Please select a circuit");
                char x = GetKey();
                string newInput = "" + x;
                bool key = int.TryParse(newInput, out input);
                var circuit = new CircuitBuilder().Build(input);
                circuit.StartCircuit();
            }
        }

        public char GetKey()
        {
            char x = 'x';
            ConsoleKeyInfo input;
            while (x != '1' && x != '4' && x != '5' && x != (char)13)
            {
                input = Console.ReadKey();
                x = input.KeyChar;
                Console.WriteLine();
                if (x != '1' && x != '4' && x != '5' && x != (char)13)
                {
                    Console.WriteLine("Please type 1,4 or 5");
                }
                if (x == (char)13)
                {
                    System.Environment.Exit(1);
                }
            }
            return x;
        }
    }
}
