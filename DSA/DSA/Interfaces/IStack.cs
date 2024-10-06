namespace DSA.Interfaces
{
    public interface IStack<T>
    {
        T Pop();
        T Peek();
        void Push(T item);
        int Length { get; }
    }
}
