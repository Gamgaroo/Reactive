namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveDictionary<TKey, TValue> : IReadOnlyReactiveDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        void Remove(TKey key);
    }
}