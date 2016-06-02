using AlgorithmsAndDataStructuresPart1;
using FluentAssertions;
using NUnit.Framework;

namespace AlgorithmsAndDataStructuresPart1Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void GivenAnEmptyLinkedList_ShouldAddNodeAsTheHeadAndTail()
        {
            //arrange
            LinkedList linkedList = new LinkedList();
            Node first = new Node() { Value = 3 };

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
        public void GivenALinkedListWithOneNode_ShouldAddANodeAsTheHead()
        {
            //arrange
            LinkedList linkedList = new LinkedList();
            Node first = new Node() { Value = 3 };
            linkedList.AddFirst(first);

            //act
            Node second = new Node() { Value = 5 };
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
            LinkedList linkedList = new LinkedList();
            Node first = new Node() { Value = 3 };
            linkedList.AddFirst(first);

            //act
            Node second = new Node() { Value = 5 };
            linkedList.AddFirst(second);
            Node third = new Node() { Value = 7 };
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
        public void GivenAnEmptyLinkedList_ShouldAddANodeAsTheTail()
        {
            //arrange
            LinkedList linkedList = new LinkedList();

            //act
            Node first = new Node() { Value = 3 };
            linkedList.AddLast(first);

            //arrange
            linkedList.Count.Should().Be(1);
            linkedList.Head.Value.Should().Be(first.Value);
            linkedList.Head.Next.Should().BeNull();
            linkedList.Tail.Value.Should().Be(first.Value);
            linkedList.Tail.Next.Should().BeNull();

        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddANodeAsTheTail()
        {
            //arrange
            LinkedList linkedList = new LinkedList();
            Node first = new Node() { Value = 3 };
            linkedList.AddFirst(first);

            //act
            Node second = new Node() { Value = 5 };
            linkedList.AddLast(second);

            //assert
            linkedList.Count.Should().Be(2);
            linkedList.Head.Value.Should().Be(first.Value);
            linkedList.Head.Next.Should().Be(second);
            linkedList.Tail.Value.Should().Be(second.Value);
            linkedList.Tail.Next.Should().BeNull();
        }
    }
}
