using System;
using Gamgaroo.Reactive.Runtime.Abstractions;

namespace Gamgaroo.Reactive.Runtime
{
    public sealed class ReactiveProperty<T> : IReactiveProperty<T>
    {
        private T _value;

        public ReactiveProperty()
        {
        }

        public ReactiveProperty(T value)
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