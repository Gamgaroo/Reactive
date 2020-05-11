using System;
using System.Collections.Generic;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveList<T>
    {
        IReadOnlyList<T> Items { get; }
        void Add(T item);
        void Remove(T item);

        event Action<T> OnItemAdded;
        event Action<T> OnItemRemoved;
    }
}