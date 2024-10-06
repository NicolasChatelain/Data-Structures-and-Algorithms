using DSA.Interfaces;
namespace DSA
{
    public class Node<T>
    {
        public T value;
        public Node<T>? next;
    }

    public class Queue<T> : IQueue<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;

        public int Length { get; private set; }

        public Queue()
        {
            _head = _tail = null;
            Length = 0;
        }

        public T? Dequeue()
        {
            if (_head is null)
            {
                return default(T);
            }
            Length--;
            if (Length == 0)
            {
                _tail = null;
            }
            var value = _head.value;
            _head = _head.next;
            return value;
        }

        public void Enqueue(T item)
        {
            var node = new Node<T>() { value = item };

            Length++;
            if (_tail is null)
            {
                _tail = _head = node;
                return;
            }

            _tail.next = node;
            _tail = node;
        }

        public T? Peek()
        {
            if (_head is null)
                return default(T);
            return _head.value;
        }
    }
}
