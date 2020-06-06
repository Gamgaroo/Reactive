using System;
using System.Collections.Generic;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReadOnlyReactiveDictionary<TKey, TValue>
    {
        IReadOnlyDictionary<TKey, TValue> Items { get; }

        TValue this[TKey key] { get; }

        event Action<TKey, TValue> OnItemAdded;
        event Action<TKey, TValue> OnItemRemoved;
    }
}