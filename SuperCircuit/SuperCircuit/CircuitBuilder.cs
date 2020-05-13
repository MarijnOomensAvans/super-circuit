using View;

namespace SuperCircuit
{
    internal class CircuitBuilder
    {
        public CircuitBuilder()
        {
        }

        public void Build()
        {
            Circuit circuit = new FileParser().ReadCircuit();
        }
    }
}