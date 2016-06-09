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
            LinkedListNode first = new LinkedListNode() { Value = 3 };
            LinkedListNode middle = new LinkedListNode() { Value = 5 };
            first.Next = middle;
            LinkedListNode last = new LinkedListNode() { Value = 7 };
            middle.Next = last;

            //act
            PrintList(first);
        }

        private void PrintList(LinkedListNode linkedListNode)
        {
            while (linkedListNode != null)
            {
                Console.WriteLine(linkedListNode.Value);
                linkedListNode = linkedListNode.Next;
            }
        }
    }
}
