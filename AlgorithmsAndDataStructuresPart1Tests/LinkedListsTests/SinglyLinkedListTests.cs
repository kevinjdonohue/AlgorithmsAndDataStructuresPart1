using System;
using System.Collections;
using AlgorithmsAndDataStructuresPart1;
using AlgorithmsAndDataStructuresPart1.LinkedLists;
using FluentAssertions;
using NUnit.Framework;

namespace AlgorithmsAndDataStructuresPart1Tests.LinkedListsTests
{
    [TestFixture]
    public class SinglyLinkedListTests
    {
        private SinglyLinkedListNode<int> _first;
        private SinglyLinkedListNode<int> _second;
        private SinglyLinkedListNode<int> _third;
        private SInglyLinkedList<int> _sInglyLinkedList;

        [SetUp]
        public void SetUp()
        {
            _first = new SinglyLinkedListNode<int>(3);
            _second = new SinglyLinkedListNode<int>(5);
            _third = new SinglyLinkedListNode<int>(7);
            _sInglyLinkedList = new SInglyLinkedList<int>();
        }

        [Test]
        public void GivenAnEmptyLinkedList_ShouldAddNodeAsTheHeadAndTail()
        {
            //arrange

            //act
            _sInglyLinkedList.AddFirst(_first);

            //assert
            // Head(3, null), Tail(3, null) 
            _sInglyLinkedList.Count.Should().Be(1);
            _sInglyLinkedList.Head.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Head.Next.Should().BeNull();
            _sInglyLinkedList.Tail.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenAnEmptyLinkedList_ShouldAddNodeAsTheTailAndHead()
        {
            //arrange

            //act
            _sInglyLinkedList.AddLast(_first);

            //assert
            _sInglyLinkedList.Count.Should().Be(1);
            _sInglyLinkedList.Head.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Head.Next.Should().BeNull();
            _sInglyLinkedList.Tail.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();

        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddANodeAsTheHead()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);

            //act
            _sInglyLinkedList.AddFirst(_second);

            //assert
            // Head(5, _first) --> Tail(3, null)
            _sInglyLinkedList.Count.Should().Be(2);
            _sInglyLinkedList.Head.Value.Should().Be(_second.Value);
            _sInglyLinkedList.Head.Next.Should().Be(_first);
            _sInglyLinkedList.Tail.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddTwoNodes()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);

            //act
            _sInglyLinkedList.AddFirst(_second);
            _sInglyLinkedList.AddFirst(_third);

            //assert
            // Head[Third](7, Second) --> Second(5, First) --> Tail[First](3, null)
            _sInglyLinkedList.Count.Should().Be(3);
            _sInglyLinkedList.Head.Value.Should().Be(_third.Value);
            _sInglyLinkedList.Head.Next.Should().Be(_second);
            _sInglyLinkedList.Tail.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldAddANodeAsTheTail()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);

            //act
            _sInglyLinkedList.AddLast(_second);

            //assert
            _sInglyLinkedList.Count.Should().Be(2);
            _sInglyLinkedList.Head.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Head.Next.Should().Be(_second);
            _sInglyLinkedList.Tail.Value.Should().Be(_second.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldRemoveTheFirstNode_MakingTheListEmpty()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);

            //act
            _sInglyLinkedList.RemoveFirst();

            //assert
            _sInglyLinkedList.Count.Should().Be(0);
            _sInglyLinkedList.Head.Should().BeNull();
            _sInglyLinkedList.Tail.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithTwoNodes_ShouldRemoveTheFirstNode()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);
            _sInglyLinkedList.AddLast(_second);

            //act
            _sInglyLinkedList.RemoveFirst();

            //assert
            _sInglyLinkedList.Count.Should().Be(1);
            _sInglyLinkedList.Head.Should().Be(_second);
            _sInglyLinkedList.Tail.Should().Be(_second);
        }

        [Test]
        public void GivenALinkedListWithThreeNodes_ShouldRemoveTheFirstNode()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);
            _sInglyLinkedList.AddLast(_second);
            _sInglyLinkedList.AddLast(_third);

            //act
            _sInglyLinkedList.RemoveFirst();

            //assert
            _sInglyLinkedList.Count.Should().Be(2);
            _sInglyLinkedList.Head.Value.Should().Be(_second.Value);
            _sInglyLinkedList.Head.Next.Should().Be(_third);
            _sInglyLinkedList.Tail.Value.Should().Be(_third.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithOneNode_ShouldRemoveTheLastNode_MakingTheListEmpty()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);

            //act
            _sInglyLinkedList.RemoveLast();

            //assert
            _sInglyLinkedList.Count.Should().Be(0);
            _sInglyLinkedList.Head.Should().BeNull();
            _sInglyLinkedList.Tail.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithThreeNodes_ShouldRemoveTheLastNode()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);
            _sInglyLinkedList.AddLast(_second);
            _sInglyLinkedList.AddLast(_third);

            _sInglyLinkedList.Head.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Head.Next.Should().Be(_second);
            _sInglyLinkedList.Tail.Value.Should().Be(_third.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();

            //act
            _sInglyLinkedList.RemoveLast();

            //assert
            _sInglyLinkedList.Count.Should().Be(2);
            _sInglyLinkedList.Head.Value.Should().Be(_first.Value);
            _sInglyLinkedList.Head.Next.Should().Be(_second);
            _sInglyLinkedList.Tail.Value.Should().Be(_second.Value);
            _sInglyLinkedList.Tail.Next.Should().BeNull();
        }

        [Test]
        public void GivenALinkedListWithThreeNodes_ShouldEnumerateOverTheList()
        {
            //arrange
            _sInglyLinkedList.AddFirst(_first);
            _sInglyLinkedList.AddLast(_second);
            _sInglyLinkedList.AddLast(_third);

            //act
            IEnumerator enumerator = _sInglyLinkedList.GetEnumerator();

            //assert
            while (enumerator.MoveNext())
            {
                Console.WriteLine("Current LinkedListNode value is: {0}", (int)enumerator.Current);
            }
        }
    }
}
