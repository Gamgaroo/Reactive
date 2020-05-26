using System;
using System.Collections.Generic;

namespace Gamgaroo.Reactive.Runtime.Abstractions
{
    public interface IReadOnlyReactiveList<out T>
    {
        IReadOnlyList<T> Items { get; }

        event Action<T> OnItemAdded;
        event Action<T> OnItemRemoved;
    }
}