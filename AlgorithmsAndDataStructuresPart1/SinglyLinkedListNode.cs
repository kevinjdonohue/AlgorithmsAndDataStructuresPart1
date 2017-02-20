namespace AlgorithmsAndDataStructuresPart1
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }
    }
}
