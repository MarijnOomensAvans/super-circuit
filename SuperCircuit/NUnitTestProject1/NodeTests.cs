using NUnit.Framework;
using SuperCircuit;
using SuperCircuit.Models;

namespace NUnitTestProject1
{
    public class NodeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAndGateOnSucces()
        {
            string input = "On";
            string expected = "On";
            AndGate node = new AndGate();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestAndGateOffSucces()
        {
            string input = "On";
            string expected = "Off";
            AndGate node = new AndGate();
            node.inputValues.Add(new OffValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestNandGateOnSucces()
        {
            string input = "On";
            string expected = "On";
            NandGate node = new NandGate();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestNandGateOffSucces()
        {
            string input = "Off";
            string expected = "Off";
            NandGate node = new NandGate();
            node.inputValues.Add(new OffValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestNorGateOnSucces()
        {
            string input = "On";
            string expected = "On";
            NorGate node = new NorGate();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestNorGateOffSucces()
        {
            string input = "Off";
            string expected = "Off";
            NorGate node = new NorGate();
            node.inputValues.Add(new OffValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestNotGateOnSucces()
        {
            string input = "On";
            string expected = "Off";
            NotGate node = new NotGate();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestNotGateOffSucces()
        {
            string input = "Off";
            string expected = "On";
            NotGate node = new NotGate();
            node.inputValues.Add(new OffValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestOrGateOnSucces()
        {
            string input = "On";
            string expected = "On";
            OrGate node = new OrGate();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestOrGateOffSucces()
        {
            string input = "Off";
            string expected = "Off";
            OrGate node = new OrGate();
            node.inputValues.Add(new OffValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestOutputOnSucces()
        {
            string input = "On";
            string expected = "On";
            OutputNode node = new OutputNode();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestOutputOffSucces()
        {
            string input = "Off";
            string expected = "Off";
            OutputNode node = new OutputNode();
            node.inputValues.Add(new OffValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestXOrOnSucces()
        {
            string input = "On";
            string expected = "On";
            XOrGate node = new XOrGate();
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestXOrOffSucces()
        {
            string input = "Off";
            string expected = "Off";
            XOrGate node = new XOrGate();
            node.inputValues.Add(new OffValue().getValue());
            node.inputValues.Add(new OnValue().getValue());

            string output = node.CalculateOutput(input);

            Assert.AreEqual(expected, output);
        }
    }
}