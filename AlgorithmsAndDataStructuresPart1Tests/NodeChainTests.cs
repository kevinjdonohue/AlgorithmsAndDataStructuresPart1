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
            SinglyLinkedListNode<int> first = new SinglyLinkedListNode<int>(3);
            SinglyLinkedListNode<int> middle = new SinglyLinkedListNode<int>(5);
            first.Next = middle;
            SinglyLinkedListNode<int> last = new SinglyLinkedListNode<int>(7);
            middle.Next = last;

            //act
            PrintList(first);
        }

        private void PrintList(SinglyLinkedListNode<int> linkedListNode)
        {
            while (linkedListNode != null)
            {
                Console.WriteLine(linkedListNode.Value);
                linkedListNode = linkedListNode.Next;
            }
        }
    }
}
