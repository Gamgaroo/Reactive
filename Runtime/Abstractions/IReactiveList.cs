using System;
using System.Collections.Generic;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReactiveList<T>
    {
        void Add(T item);
        void Remove(T item);

        IReadOnlyList<T> Items { get; }

        event Action<T> OnItemAdded;
        event Action<T> OnItemRemoved;
    }
}