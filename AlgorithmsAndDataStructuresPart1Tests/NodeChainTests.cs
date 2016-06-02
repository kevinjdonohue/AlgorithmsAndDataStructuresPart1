using AlgorithmsAndDataStructuresPart1;
using NUnit.Framework;
using System;

namespace AlgorithmsAndDataStructuresPart1Tests
{
    [TestFixture]
    public class NodeChainTests
    {
        [Test]
        public void NodeChainExample()
        {
            //arrange
            Node first = new Node() { Value = 3 };
            Node middle = new Node() { Value = 5 };
            first.Next = middle;
            Node last = new Node() { Value = 7 };
            middle.Next = last;

            //act
            PrintList(first);
        }

        private void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
