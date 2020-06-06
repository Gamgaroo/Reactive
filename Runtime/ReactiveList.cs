using System;
using System.Collections.Generic;
using Gamgaroo.Reactive.Runtime.Abstractions;

namespace Gamgaroo.Reactive.Runtime
{
    public sealed class ReactiveList<T> : IReactiveList<T>
    {
        private readonly List<T> _items;

        public ReactiveList()
        {
            _items = new List<T>();
        }

        public ReactiveList(IEnumerable<T> items)
        {
            _items = new List<T>(items);
        }

        public void Add(T item)
        {
            _items.Add(item);

            OnItemAdded?.Invoke(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);

            OnItemRemoved?.Invoke(item);
        }

        public IReadOnlyList<T> Items => _items;

        public T this[int index] => _items[index];

        public event Action<T> OnItemAdded;
        public event Action<T> OnItemRemoved;
    }
}