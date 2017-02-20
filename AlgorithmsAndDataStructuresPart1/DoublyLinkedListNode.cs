﻿using System;

namespace AlgorithmsAndDataStructuresPart1
{
	public class DoublyLinkedListNode<T>
	{
		public T Value { get; private set; }
				
		public DoublyLinkedListNode(T value)
		{
			Value = value;
		}

		public DoublyLinkedListNode<T> Next { get; set; }

		public DoublyLinkedListNode<T> Previous { get; set; }
	}
}
