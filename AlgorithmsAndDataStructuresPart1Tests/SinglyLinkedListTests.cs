using AlgorithmsAndDataStructuresPart1;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections;

namespace AlgorithmsAndDataStructuresPart1Tests
{
    [TestFixture]
    public class SinglyLinkedListTests
    {
        [Test]
        public void GivenAnEmptyLinkedList_ShouldAddNodeAsTheHeadAndTail()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode first = new SinglyLinkedListNode() { Value = 3 };

            //act
            linkedList.AddFirst(first);

            //assert
            // Head(3, null), Tail(3, null) 
            linkedList.Count.Should().Be(1);
            linkedList.Head.Value.Should().Be(first.Value);
            linkedList.Head.Next.Should().BeNull();
            linkedList.Tail.Value.Should().Be(first.Value);
            linkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenAnEmptyLinkedList_ShouldAddNodeAsTheTailAndHead()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();

            //act
            SinglyLinkedListNode first = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddLast(first);

            //assert
            linkedList.Count.Should().Be(1);
            linkedList.Head.Value.Should().Be(first.Value);
            linkedList.Head.Next.Should().BeNull();
            linkedList.Tail.Value.Should().Be(first.Value);
            linkedList.Tail.Next.Should().BeNull();

        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddANodeAsTheHead()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode first = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(first);

            //act
            SinglyLinkedListNode second = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddFirst(second);

            //assert
            // Head(5, first) --> Tail(3, null)
            linkedList.Count.Should().Be(2);
            linkedList.Head.Value.Should().Be(second.Value);
            linkedList.Head.Next.Should().Be(first);
            linkedList.Tail.Value.Should().Be(first.Value);
            linkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddTwoNodes()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode first = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(first);

            //act
            SinglyLinkedListNode second = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddFirst(second);
            SinglyLinkedListNode third = new SinglyLinkedListNode() { Value = 7 };
            linkedList.AddFirst(third);

            //assert
            // Head[Third](7, Second) --> Second(5, First) --> Tail[First](3, null)
            linkedList.Count.Should().Be(3);
            linkedList.Head.Value.Should().Be(third.Value);
            linkedList.Head.Next.Should().Be(second);
            linkedList.Tail.Value.Should().Be(first.Value);
            linkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddANodeAsTheTail()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode first = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(first);

            //act
            SinglyLinkedListNode second = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddLast(second);

            //assert
            linkedList.Count.Should().Be(2);
            linkedList.Head.Value.Should().Be(first.Value);
            linkedList.Head.Next.Should().Be(second);
            linkedList.Tail.Value.Should().Be(second.Value);
            linkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldRemoveTheFirstNode_MakingTheListEmpty()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode firstLinkedListNode = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(firstLinkedListNode);

            //act
            linkedList.RemoveFirst();

            //assert
            linkedList.Count.Should().Be(0);
            linkedList.Head.Should().BeNull();
            linkedList.Tail.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithTwoNodes_ShouldRemoveTheFirstNode()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode firstLinkedListNode = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(firstLinkedListNode);
            SinglyLinkedListNode secondLinkedListNode = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddLast(secondLinkedListNode);

            //act
            linkedList.RemoveFirst();

            //assert
            linkedList.Count.Should().Be(1);
            linkedList.Head.Should().Be(secondLinkedListNode);
            linkedList.Tail.Should().Be(secondLinkedListNode);
        }

        [Test]
        public void GivenALinkedListWithThreeNodes_ShouldRemoveTheFirstNode()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode firstLinkedListNode = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(firstLinkedListNode);
            SinglyLinkedListNode secondLinkedListNode = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddLast(secondLinkedListNode);
            SinglyLinkedListNode thirdLinkedListNode = new SinglyLinkedListNode() { Value = 7 };
            linkedList.AddLast(thirdLinkedListNode);

            //act
            linkedList.RemoveFirst();

            //assert
            linkedList.Count.Should().Be(2);
            linkedList.Head.Value.Should().Be(secondLinkedListNode.Value);
            linkedList.Head.Next.Should().Be(thirdLinkedListNode);
            linkedList.Tail.Value.Should().Be(thirdLinkedListNode.Value);
            linkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldRemoveTheLastNode_MakingTheListEmpty()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode firstLinkedListNode = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(firstLinkedListNode);

            //act
            linkedList.RemoveLast();

            //assert
            linkedList.Count.Should().Be(0);
            linkedList.Head.Should().BeNull();
            linkedList.Tail.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithThreeNodes_ShouldRemoveTheLastNode()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode firstLinkedListNode = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(firstLinkedListNode);
            SinglyLinkedListNode secondLinkedListNode = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddLast(secondLinkedListNode);
            SinglyLinkedListNode thirdLinkedListNode = new SinglyLinkedListNode() { Value = 7 };
            linkedList.AddLast(thirdLinkedListNode);

            linkedList.Head.Value.Should().Be(firstLinkedListNode.Value);
            linkedList.Head.Next.Should().Be(secondLinkedListNode);
            linkedList.Tail.Value.Should().Be(thirdLinkedListNode.Value);
            linkedList.Tail.Next.Should().BeNull();

            //act
            linkedList.RemoveLast();

            //assert
            linkedList.Count.Should().Be(2);
            linkedList.Head.Value.Should().Be(firstLinkedListNode.Value);
            linkedList.Head.Next.Should().Be(secondLinkedListNode);
            linkedList.Tail.Value.Should().Be(secondLinkedListNode.Value);
            linkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithThreeNodes_ShouldEnumerateOverTheList()
        {
            //arrange
            SinglyLinkedList linkedList = new SinglyLinkedList();
            SinglyLinkedListNode firstLinkedListNode = new SinglyLinkedListNode() { Value = 3 };
            linkedList.AddFirst(firstLinkedListNode);
            SinglyLinkedListNode secondLinkedListNode = new SinglyLinkedListNode() { Value = 5 };
            linkedList.AddLast(secondLinkedListNode);
            SinglyLinkedListNode thirdLinkedListNode = new SinglyLinkedListNode() { Value = 7 };
            linkedList.AddLast(thirdLinkedListNode);

            //act
            IEnumerator enumerator = linkedList.GetEnumerator();

            //assert
            while (enumerator.MoveNext())
            {
                Console.WriteLine("Current LinkedListNode value is: {0}", (int)enumerator.Current);
            }
        }
    }
}
