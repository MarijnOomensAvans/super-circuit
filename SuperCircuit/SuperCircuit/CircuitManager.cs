using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCircuit
{
    public class CircuitManager
    {
        public CircuitManager()
        {
            this.getInput();
        }

        private void getInput()
        {
            Console.WriteLine("Please select a circuit");
            int input;
            bool valid = false;
            do
            {
                char x = GetKey();
                string newInput = "" + x;
                valid = int.TryParse(newInput, out input);
            } while (!valid);
            var circuit = new CircuitBuilder().Build(input);
            circuit.StartCircuit();

        }

        public char GetKey()
        {
            char x = 'x';
            ConsoleKeyInfo input;
            while (x != '1' && x != '2' && x != '3' && x != '4' && x != '5')
            {
                input = Console.ReadKey();
                x = input.KeyChar;
                Console.WriteLine();
                if (x != '1' && x != '2' && x != '3' && x != '4' && x != '5')
                {
                    Console.WriteLine("Please type 1,2,3,4 or 5");
                }
            }
            return x;
        }
    }
}
