using System;
using System.Collections.Generic;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        void Remove(TKey key);

        IReadOnlyDictionary<TKey, TValue> Items { get; }

        event Action<TKey, TValue> OnItemAdded;
        event Action<TKey, TValue> OnItemRemoved;
    }
}