namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveList<T> : IReadOnlyReactiveList<T>
    {
        void Add(T item);
        void Remove(T item);
    }
}