using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresPart1
{
    public class SInglyLinkedList<T> : ICollection<T>
    {
        public SinglyLinkedListNode<T> Head { get; private set; }
        public SinglyLinkedListNode<T> Tail { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new SinglyLinkedListNode<T>(value));
        }

        public void AddFirst(SinglyLinkedListNode<T> node)
        {
            SinglyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;

            if (Count == 1)
            {
                Tail = node;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new SinglyLinkedListNode<T>(value));
        }

        public void AddLast(SinglyLinkedListNode<T> node)
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

        public void RemoveLast()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }

            if (Count > 1)
            {
                SinglyLinkedListNode<T> temp = Head;

                while (temp.Next != Tail)
                {
                    temp = temp.Next;
                }

                temp.Next = null;

                Tail = temp;
            }

            Count--;
        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            SinglyLinkedListNode<T> previous = null;
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        //prev: 3
                        //current: 5
                        //next: 7
                        // Before:  Head -> 3 -> 5 -> 7
                        //After:    Head -> 3 ------> 7
                        previous.Next = current.Next;

                        //prev:  3
                        //current: 5
                        //next: null
                        //Before:  Head -> 3 -> 5 -> null
                        //After:   Head -> 3 ------> null
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;

            }

            return false;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            SinglyLinkedListNode<T> current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>) this).GetEnumerator();
        }
    }
}