namespace DSA.Interfaces
{
    public interface IQueue<T>
    {
        int Length { get; }
        T? Peek();
        T? Dequeue();
        void Enqueue(T item);
    }
}
