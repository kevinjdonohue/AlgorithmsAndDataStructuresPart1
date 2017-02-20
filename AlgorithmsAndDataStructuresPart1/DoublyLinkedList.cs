using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresPart1
{
    public class DoublyLinkedList<T>: ICollection<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }

        public void AddFirst(DoublyLinkedListNode<T> node)
        {
            DoublyLinkedListNode<T> previousHead = Head;
            Head = node;
            Head.Next = previousHead;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
            else
            {
                previousHead.Previous = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }

        public void AddLast(DoublyLinkedListNode<T> newTail)
        {
            if (Count == 0)
            {
                Head = newTail;
            }

            if (Count > 0)
            {
                Tail.Next = newTail;
                newTail.Previous = Tail;
            }

            Tail = newTail;
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
                Head.Previous = null;
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
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
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
            DoublyLinkedListNode<T> current = Head;

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
            DoublyLinkedListNode<T> current = Head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        //prev: 3
                        //current: 5
                        //next: 7
                        // Before:  Head -> 3 <-> 5 <-> 7 <-> null
                        //After:    Head -> 3 <-------> 7 <-> null
                        previous.Next = current.Next;

                        //prev:  3
                        //current: 5
                        //next: null
                        //Before:  Head -> 3 <-> 5 <-> null
                        //After:   Head -> 3 <-------> null
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
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
            DoublyLinkedListNode<T> current = Head;

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