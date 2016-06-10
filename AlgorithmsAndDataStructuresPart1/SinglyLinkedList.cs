using System.Collections;

namespace AlgorithmsAndDataStructuresPart1
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode Head { get; set; }
        public SinglyLinkedListNode Tail { get; set; }
        public int Count { get; set; }

        public void AddFirst(int value)
        {
            AddFirst(new SinglyLinkedListNode() { Value = value });
        }

        public void AddFirst(SinglyLinkedListNode node)
        {
            SinglyLinkedListNode temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;

            if (Count == 1)
            {
                Tail = node;
            }
        }

        public void AddLast(int value)
        {
            AddLast(new SinglyLinkedListNode() { Value = value });
        }

        public void AddLast(SinglyLinkedListNode node)
        {
            if (Count == 0)
            {
                Head = node;
            }

            if (Count > 0)
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }

        public void RemoveLast()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }

            if (Count > 1)
            {
                SinglyLinkedListNode temp = Head;

                while (temp.Next != Tail)
                {
                    temp = temp.Next;
                }

                temp.Next = null;

                Tail = temp;
            }

            Count--;
        }

        public void RemoveFirst()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }

            if (Count > 1)
            {
                Head = Head.Next;
            }

            Count--;
        }

        public IEnumerator GetEnumerator()
        {
            SinglyLinkedListNode current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}