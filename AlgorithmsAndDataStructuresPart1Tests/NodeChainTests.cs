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
            SinglyLinkedListNode first = new SinglyLinkedListNode() { Value = 3 };
            SinglyLinkedListNode middle = new SinglyLinkedListNode() { Value = 5 };
            first.Next = middle;
            SinglyLinkedListNode last = new SinglyLinkedListNode() { Value = 7 };
            middle.Next = last;

            //act
            PrintList(first);
        }

        private void PrintList(SinglyLinkedListNode linkedListNode)
        {
            while (linkedListNode != null)
            {
                Console.WriteLine(linkedListNode.Value);
                linkedListNode = linkedListNode.Next;
            }
        }
    }
}
