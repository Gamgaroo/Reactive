using System;
using System.Collections.Generic;
using Gamgaroo.Reactive.Runtime.Abstractions;

namespace Gamgaroo.Reactive.Runtime
{
    public sealed class ReactiveDictionary<TKey, TValue> : IReactiveDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary;

        public ReactiveDictionary()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public ReactiveDictionary(IDictionary<TKey, TValue> dictionary)
        {
            _dictionary = new Dictionary<TKey, TValue>(dictionary);
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);

            OnItemAdded?.Invoke(key, value);
        }

        public void Remove(TKey key)
        {
            var value = _dictionary[key];

            _dictionary.Remove(key);

            OnItemRemoved?.Invoke(key, value);
        }

        public IReadOnlyDictionary<TKey, TValue> Items => _dictionary;

        public TValue this[TKey key] => _dictionary[key];

        public event Action<TKey, TValue> OnItemAdded;
        public event Action<TKey, TValue> OnItemRemoved;
    }
}