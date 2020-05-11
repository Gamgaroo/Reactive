using System;
using Gamgaroo.Reactive.Runtime.Abstractions;
using UnityEngine;

namespace Gamgaroo.Reactive.Runtime.Serializable
{
    public abstract class SerializableReactiveProperty<T> : IReactiveProperty<T>
    {
        [SerializeField]
        private T _value;

        protected SerializableReactiveProperty()
        {
        }

        protected SerializableReactiveProperty(T value)
        {
            _value = value;
        }

        public T Value
        {
            get => _value;
            set => SetValue(value);
        }

        public event Action<T> OnValueChanged;

        private void SetValue(T value)
        {
            if (_value != null && _value.Equals(value))
                return;

            _value = value;

            OnValueChanged?.Invoke(_value);
        }
    }
}