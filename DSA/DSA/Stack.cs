using DSA.Interfaces;

namespace DSA
{
    public class StackNode<T>
    {
        public required T Value { get; set; }
        public StackNode<T>? Previous { get; set; }
    }

    public class Stack<T> : IStack<T>
    {
        public int Length { get; private set; } = 0;
        private StackNode<T>? _head;

        public T Peek()
        {
            return _head.Value;
        }

        public T Pop() 
        {
            Length--; // fout mag niet onder 0
            var rv = _head.Value;
            var previousNode = _head.Previous;

            _head = previousNode;
            _head.Previous = previousNode.Previous;

            return rv;
        }

        public void Push(T item)
        {
            Length++;
            StackNode<T> node = new() { Value = item, Previous = null };
            if (_head is null) // if Stack is empty
            {
                _head = node;
                return;
            }


            var prevNode = _head;
            _head = node;
            _head.Previous = prevNode;

        }

    }
}
